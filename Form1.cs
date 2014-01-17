using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

// TODO:
// - regexp name matches
// - bacth action - choose match/nomatch regexp
// - choose dir1 vs dir2
// - PayPal

namespace FindDups
{
    public partial class MainForm : Form
    {
        ArrayList fileList, directoryList;
        int pos, limit;

        public MainForm()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            if (running)
                running = false;
            else
                Close();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (fileList == null)
            {
                nextButton.Enabled = false;
                InitFileList();
                UpdateList(pos=0);
            }
            else
                Next();
        }

        static public string BrowsePath(string description)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            // Set the help text description for the FolderBrowserDialog.
            folderBrowser.Description = description;

            // Do not allow the user to create new files via the FolderBrowserDialog.
            folderBrowser.ShowNewFolderButton = false;

            folderBrowser.RootFolder = System.Environment.SpecialFolder.MyComputer;

            // Show the FolderBrowserDialog.
            DialogResult result = folderBrowser.ShowDialog();
            if (result == DialogResult.OK)
            {
                return folderBrowser.SelectedPath;
            }
            return null;
        }

        void BrowsePath(TextBox t)
        {
            string f = BrowsePath("Choose Directory");
            if (f != null)
            {
                t.Text = f;
            }
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            BrowsePath(path1TextBox);
        }

        private void prevButton_Click(object sender, EventArgs e)
        {
            Prev();
        }

        void Next()
        {
            if (pos < limit)
            {
                UpdateList(++pos);
            }
        }

        void Prev()
        {
            if (pos > 0)
            {
                UpdateList(--pos);
            }
        }

        void UpdateList(int p)
        {
            filesCheckedListBox.Items.Clear();
            prevButton.Enabled = (p > 0);
            deleteButton.Enabled = false;
            if (fileList != null && fileList.Count > 0)
            {
                batchButton.Enabled = checkAllButton.Enabled = checkNoneButton.Enabled = checkNewerButton.Enabled = checkOlderButton.Enabled = invertButton.Enabled = true;
                nextButton.Enabled = (p < limit);
                toolStripStatusLabel.Text = "";
                try
                {
                    ArrayList files = null;
                    if (mode == Mode.File)
                    {
                        files = (ArrayList)fileList[p];
                    }
                    else if (directoryList.Count > 0)
                    {
                        files = (ArrayList)directoryList[p];
                    }

                    if (files != null)
                    {
                        int stripLen1 = path1TextBox.Text.Length;
                        if (!path1TextBox.Text.EndsWith("\\"))
                            ++stripLen1;
                        int stripLen2 = path2TextBox.Text.Length;
                        if (!path1TextBox.Text.EndsWith("\\"))
                            ++stripLen2;
                        foreach (FileInfo fi in files)
                        {
                            string s;
                            if (path2TextBox.Text.Length == 0)
                                s = fi.FullName.Substring(stripLen1);
                            else if (fi.FullName.ToLower().StartsWith(path2TextBox.Text.ToLower()))
                                s = "<Directory2>\\" + fi.FullName.Substring(stripLen2);
                            else
                                s = "<Directory1>\\" + fi.FullName.Substring(stripLen1);
                            filesCheckedListBox.Items.Add(s);
                            // TODO - we need to indicate which directory a file belongs to and what its opposite is, and we have clumps of different but non-unique files
                            // in directory mode. One possibility might be to color code based on directory and not alllow sorting so that the pairs are shown together 
                        }
                        toolStripStatusLabel.Text = String.Format("Set {0} of {1}", p + 1, fileList.Count);
                    }
                    else
                    {
                        toolStripStatusLabel.Text = "No more duplicates";
                    }
                }
                catch
                {
                }
            }
            else
            {
                batchButton.Enabled = checkAllButton.Enabled = checkNoneButton.Enabled = checkNewerButton.Enabled = checkOlderButton.Enabled = invertButton.Enabled = false;
                toolStripStatusLabel.Text = "No duplicates";
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            Delete();
        }

        void Delete()
        {
            if (fileList == null || fileList.Count <= pos)
                return; // sanity

            ArrayList files = null;
            if (mode == Mode.File)
            {
                files = (ArrayList)fileList[pos];
            }
            else if (directoryList.Count > 0)
            {
                files = (ArrayList)directoryList[pos];
            }
            int checkedCount = 0;
            for (int i = 0; i < filesCheckedListBox.Items.Count; i++)
            {
                if (filesCheckedListBox.GetItemChecked(i))
                    ++checkedCount;
            }
            if (checkedCount > 0)
            {
                if (checkedCount == filesCheckedListBox.Items.Count)
                {
                    if (MessageBox.Show("Are you sure you want to delete all items in this set?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.No)
                        return;
                }
                for (int i = 0; i < filesCheckedListBox.Items.Count; i++)
                {
                    if (filesCheckedListBox.GetItemChecked(i))
                    {
                        string f = ((string)filesCheckedListBox.Items[i]).ToUpper();
                        string p = Path.Combine(path1TextBox.Text, f).ToUpper();
                        try
                        {
                            File.Delete(p);
                        }
                        catch (Exception ex)
                        {
                            // maybe it was permissions; reset them and try again
                            FileInfo fi = new FileInfo(p);
                            fi.Attributes = fi.Attributes & ~(FileAttributes.Archive | FileAttributes.ReadOnly | FileAttributes.Hidden);
                            fi.Delete();
                        }
                        for (int j = 0; j < files.Count; j++)
                        {
                            if (p == ((FileInfo)files[j]).FullName.ToUpper())
                            {
                                // TODO - we need to cross-remove from the directory mode entry if this is a file mode delete and vice versa
                                files.RemoveAt(j);
                                break;
                            }
                        }
                    }
                }
                if (mode == Mode.File && files.Count < 2)
                {
                    fileList.RemoveAt(pos);
                }
                else if (mode == Mode.Directory) // TODO - clean up and possibly remove the directoryList entry. We must remove all files that are no longer duplicated and then remove the entry if empty
                {
                    //directoryList.RemoveAt(pos);
                }
                else ++pos;
                if (pos > 0 && pos == fileList.Count)
                    --pos;
                if (interactiveBatch)
                    FindNextBatchGroup();
                else
                    UpdateList(pos);
            }
        }

        private void pathTextBox_TextChanged(object sender, EventArgs e)
        {
            ChangeFileFilter();
        }

        void ChangeFileFilter()
        {
            fileList = null;
            pos = 0;
            prevButton.Enabled = false;
            nextButton.Enabled = true;
            deleteButton.Enabled = false;
            toolStripStatusLabel.Text = "Click Next to begin";
        }

        private void filesCheckedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            deleteButton.Enabled = true;
        }

        void LoadFiles(string path, ArrayList files, int minSize)
        {
            try
            {
                foreach (string d in Directory.GetDirectories(path))
                {
                    if (!running) break;
                    LoadFiles(d, files, minSize);
                }
            }
            catch
            {
            }
            try
            {
                string[] suffixes = suffixTextBox.Text.Trim(' ', '\t', ';').Split(';');
                string suffix = null;
                if (suffixes != null)
                {
                    if (suffixes.Length == 0 || (suffixes.Length == 1 && String.IsNullOrEmpty(suffixes[0])))
                    {
                        suffixes = null;
                    }
                }
                if (suffixes != null && suffixes.Length == 1)
                {
                    suffix = suffixes[0];
                    suffixes = null;
                }

                foreach (string f in Directory.GetFiles(path))
                {
                    if (!running) break;
                    if (suffix != null)
                    {
                        if (!f.EndsWith(suffix, StringComparison.OrdinalIgnoreCase))
                            continue;
                    }
                    else if (suffixes != null)
                    {
                        bool match = false;
                        for (int i = 0; i < suffixes.Length; i++)
                        {
                            if (f.EndsWith(suffixes[i], StringComparison.OrdinalIgnoreCase))
                            {
                                match = true;
                                break;
                            }
                        }
                        if (!match)
                        {
                            continue;
                        }
                    }

                    try
                    {
                        FileInfo fi = new FileInfo(f);
                        if (fi.Length < minSize)
                            continue;
                        files.Add(fi);
                    }
                    catch
                    { }
                }
            }
            catch
            { }
            Application.DoEvents();
        }

        class FileInfoComparer : IComparer
        {
            // Summary:
            //     Compares two objects and returns a value indicating whether one is less than,
            //     equal to, or greater than the other.
            //
            // Parameters:
            //   y:
            //     The second object to compare.
            //
            //   x:
            //     The first object to compare.
            //
            // Returns:
            //     Value Condition Less than zero x is less than y. Zero x equals y. Greater
            //     than zero x is greater than y.
            //
            // Exceptions:
            //   System.ArgumentException:
            //     Neither x nor y implements the System.IComparable interface.-or- x and y
            //     are of different types and neither one can handle comparisons with the other.
            public int Compare(object x, object y)
            {
                return (int)(((FileInfo)y).Length - ((FileInfo)x).Length);
            }
        }

        byte[] ReadInitialBytes(string path, int len)
        {
            FileStream fs = null;
            try
            {
                fs = File.OpenRead(path);
                byte[] rtn = new byte[len];
                fs.Read(rtn, 0, len);
                return rtn;
            }
            catch
            {
                return null;
            }
            finally
            {
                if (fs != null)
                    fs.Close();
            }
        }

        const int readBufferSize = 1024;
        byte[] buf1 = new byte[readBufferSize];
        byte[] buf2 = new byte[readBufferSize];
        bool extensionsMustMatch = true; // TODO - make settable

        bool FileMatch(string path1, string path2, int length)
        {
            try
            {
                // compare extensions

                if (extensionsMustMatch && Path.GetExtension(path1).ToUpper() != Path.GetExtension(path2).ToUpper())
                    return false;

                int bufferLength = length;
                if (bufferLength > readBufferSize) 
                    bufferLength = readBufferSize;

                FileStream fs1 = null, fs2 = null;
                try
                {
                    fs1 = File.OpenRead(path1);
                    fs2 = File.OpenRead(path2);
                    int offset = 0;
                    while (offset < length)
                    {
                        bufferLength = Math.Min(bufferLength, length - offset);
                        if (fs1.Read(buf1, 0, bufferLength) != bufferLength)
                            return false;
                        if (fs2.Read(buf2, 0, bufferLength) != bufferLength)
                            return false;
                        for (int i = 0; i < bufferLength; i++)
                            if (buf1[i] != buf2[i])
                                return false;
                        offset += bufferLength;
                    }
                    return true;
                }
                catch (Exception ex)
                {
                    Debug.Fail(String.Format("Read error: {0}", ex.Message));
                }
                finally
                {
                    if (fs1 != null)
                        fs1.Close();
                    if (fs2 != null)
                        fs2.Close();
                }
            }
            catch (Exception ex)
            {
                Debug.Fail(String.Format("FileMatch: {0}, {1}: {2}", path1, path2, ex.Message));
            }
            return false;
        }

        volatile bool running;

        void InitFileList()
        {
            if (!Directory.Exists(path1TextBox.Text))
                return;

            Cursor.Current = Cursors.WaitCursor;
            exitButton.Text = "Abort";
            running = true;
            toolStripStatusLabel.Text = "Reading directories";

            Application.DoEvents();

            ArrayList files = new ArrayList();
            Hashtable dirs = new Hashtable();
            LoadFiles(path1TextBox.Text, files, (int)fileSizeNumericUpDown.Value);
            if (path2TextBox.Text.Length > 0 && Directory.Exists(path2TextBox.Text))
                LoadFiles(path2TextBox.Text, files, (int)fileSizeNumericUpDown.Value);

            if (running)
            {
                toolStripStatusLabel.Text = "Sorting files";
                exitButton.Enabled = false;
                
                Application.DoEvents();

                files.Sort(new FileInfoComparer());
                exitButton.Enabled = true;
                toolStripStatusLabel.Text = "Finding duplicates";
                
                Application.DoEvents();
                
                int i = 0;
                toolStripProgressBar.Visible = true;
                toolStripProgressBar.Value = 0;
                while (running)
                {
                    if (i >= (files.Count - 1))
                        break;

                    toolStripProgressBar.Value = (100 * i) / files.Count;
                    Application.DoEvents();

                    FileInfo fi = (FileInfo)files[i];
                    ArrayList dups = null;
                    int j = i + 1;
                    while (j < files.Count)
                    {
                        FileInfo fj = (FileInfo)files[j];
                        if (fi.Length != fj.Length)
                            break;
                        if (FileMatch(fi.FullName, fj.FullName, (int)fi.Length))
                        {
                            if (fileList == null)
                            {
                                fileList = new ArrayList();
                                directoryList = new ArrayList();
                            }
                            if (dups == null)
                            {
                                dups = new ArrayList();
                                dups.Add(fi);
                                fileList.Add(dups);
                            }

                            dups.Add(fj);
                            files.RemoveAt(j);
                            // add to directory mode table
                            string dirPairKey = fi.DirectoryName + "::" + fj.DirectoryName;
                            ArrayList pairTable = null;
                            if (dirs[dirPairKey] == null)
                                dirs[dirPairKey] = new ArrayList();
                            pairTable = (ArrayList)dirs[dirPairKey];
                            pairTable.Add(fi);
                            pairTable.Add(fj);
                        }
                        else
                        {
                            ++j;
                        }
                    }
                    ++i;
                }
            }
            foreach (ArrayList al in dirs.Values)
                directoryList.Add(al);
            limit = 0;
            if (mode == Mode.File && fileList != null)
                limit = fileList.Count - 1;
            else if (directoryList != null)
                limit = directoryList.Count;
            running = false;
            exitButton.Text = "Exit";
            toolStripStatusLabel.Text = "";
            toolStripProgressBar.Visible = false;
            Cursor.Current = Cursors.Default;
        }

        private void checkAllButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < filesCheckedListBox.Items.Count; i++)
            {
                filesCheckedListBox.SetItemChecked(i, true);
            }
        }

        private void checkNoneButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < filesCheckedListBox.Items.Count; i++)
            {
                filesCheckedListBox.SetItemChecked(i, false);
            }
        }

        private void checkOlderButton_Click(object sender, EventArgs e)
        {
            ArrayList files = (ArrayList)fileList[pos];
            int newest = 0;
            FileInfo fnewest = (FileInfo)files[0];
            for (int i = 1; i < filesCheckedListBox.Items.Count; i++)
            {
                FileInfo fi = (FileInfo)files[i];
                if (fi.CreationTime > fnewest.CreationTime)
                {
                    fnewest = fi;
                    newest = i;
                }
            }
            for (int i = 0; i < filesCheckedListBox.Items.Count; i++)
            {
                filesCheckedListBox.SetItemChecked(i, (i != newest));
            }
        }

        private void checkNewerButton_Click(object sender, EventArgs e)
        {
            ArrayList files = (ArrayList)fileList[pos];
            int oldest = 0;
            FileInfo foldest = (FileInfo)files[0];
            for (int i = 1; i < filesCheckedListBox.Items.Count; i++)
            {
                FileInfo fi = (FileInfo)files[i];
                if (fi.CreationTime < foldest.CreationTime)
                {
                    foldest = fi;
                    oldest = i;
                }
            }
            for (int i = 0; i < filesCheckedListBox.Items.Count; i++)
            {
                filesCheckedListBox.SetItemChecked(i, (i != oldest));
            }
        }

        private void filesCheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idx = filesCheckedListBox.SelectedIndex;
            if (idx >= 0)
                filesCheckedListBox.SetItemChecked(idx, !filesCheckedListBox.GetItemChecked(idx));
            filesCheckedListBox.ClearSelected();
        }

        private void suffixTextBox_TextChanged(object sender, EventArgs e)
        {
            ChangeFileFilter();
        }

        private void fileSizeNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            ChangeFileFilter();
        }

        int BatchSelect(int p, string requiredText, bool autoSelectLongestPaths, bool autoSelectShortestPaths, 
            bool autoSelectLongestNames, bool autoSelectShortestNames,
            bool autoSelectOldest, bool autoSelectNewest)
        {
            ArrayList files = (ArrayList)fileList[p];
            int checkedCount = 0;

            int[] pathDepths = new int[filesCheckedListBox.Items.Count];
            int shortestDepth = -1, longestDepth = -1;

            for (int i = 0; i < filesCheckedListBox.Items.Count; i++)
            {
                pathDepths[i] = 0;

                FileInfo fi = (FileInfo)files[i];

                filesCheckedListBox.SetItemChecked(i, false);

                // apply constraints

                if (requiredText.Length > 0)
                {
                    bool b = !fi.Name.ToUpper().Contains(requiredText);
                    if (b && !filesCheckedListBox.GetItemChecked(i))
                    {
                        ++checkedCount;
                        filesCheckedListBox.SetItemChecked(i, true);
                    }
                }

                if (autoSelectShortestPaths || autoSelectLongestPaths)
                {
                    pathDepths[i] = fi.FullName.Split('\\').Length;
                    if (pathDepths[i] < shortestDepth || shortestDepth == -1)
                        shortestDepth = pathDepths[i];
                    if (pathDepths[i] > longestDepth || longestDepth == -1)
                        longestDepth = pathDepths[i];                    
                }
            }
            if (autoSelectShortestPaths)
            {
                for (int i = 0; i < pathDepths.Length; i++)
                {
                    if (!filesCheckedListBox.GetItemChecked(i))
                    {
                        if (pathDepths[i] < longestDepth)
                        {
                            ++checkedCount;
                            filesCheckedListBox.SetItemChecked(i, true);
                        }
                    }
                }
            }
            else if (autoSelectLongestPaths)
            {
                for (int i = 0; i < pathDepths.Length; i++)
                {
                    if (!filesCheckedListBox.GetItemChecked(i))
                    {
                        if (pathDepths[i] > shortestDepth)
                        {
                            ++checkedCount;
                            filesCheckedListBox.SetItemChecked(i, true);
                        }
                    }
                }
            }

            if (autoSelectShortestNames)
            {
                for (int i = 0; i < pathDepths.Length; i++)
                {
                    FileInfo fi = (FileInfo)files[i];
                    int ilen = fi.Name.Length;
                    int ilenfull = fi.FullName.Length;

                    for (int j = 0; j < pathDepths.Length; j++)
                    {
                        if (j != i && pathDepths[i] == pathDepths[j])
                        {
                            fi = (FileInfo)files[j];
                            int jlen = fi.Name.Length;
                            if (ilen < jlen || (ilen == jlen && ilenfull < fi.FullName.Length))
                            {
                                if (!filesCheckedListBox.GetItemChecked(i))
                                {
                                    ++checkedCount;
                                    filesCheckedListBox.SetItemChecked(i, true);
                                }
                            }
                        }
                    }
                }
            }
            else if (autoSelectLongestNames)
            {
                for (int i = 0; i < pathDepths.Length; i++)
                {
                    FileInfo fi = (FileInfo)files[i];
                    int ilen = fi.Name.Length;
                    int ilenfull = fi.FullName.Length;

                    for (int j = 0; j < pathDepths.Length; j++)
                    {
                        if (j != i && pathDepths[i] == pathDepths[j])
                        {
                            fi = (FileInfo)files[j];
                            int jlen = fi.Name.Length;
                            if (ilen < jlen || (ilen == jlen && ilen < fi.FullName.Length))
                            {
                                if (!filesCheckedListBox.GetItemChecked(j))
                                {
                                    ++checkedCount;
                                    filesCheckedListBox.SetItemChecked(j, true);
                                }
                            }
                        }
                    }
                }
            }
            if (autoSelectOldest)
            {
                DateTime reference = ((FileInfo)files[0]).LastWriteTimeUtc;
                for (int i = 1; i < pathDepths.Length; i++)
                {
                    FileInfo fi = (FileInfo)files[i];
                    DateTime thisone = fi.LastWriteTimeUtc;
                    if (thisone < reference) reference = thisone;
                }
                for (int i = 0; i < pathDepths.Length; i++)
                {
                    FileInfo fi = (FileInfo)files[i];
                    DateTime thisone = fi.LastWriteTimeUtc;
                    if (thisone < reference && !filesCheckedListBox.GetItemChecked(i))
                    {
                        ++checkedCount;
                        filesCheckedListBox.SetItemChecked(i, true);
                    }
                }
            }
            else if (autoSelectNewest)
            {
                DateTime reference = ((FileInfo)files[0]).LastWriteTimeUtc;
                for (int i = 1; i < pathDepths.Length; i++)
                {
                    FileInfo fi = (FileInfo)files[i];
                    DateTime thisone = fi.LastWriteTimeUtc;
                    if (thisone > reference) reference = thisone;
                }
                for (int i = 0; i < pathDepths.Length; i++)
                {
                    FileInfo fi = (FileInfo)files[i];
                    DateTime thisone = fi.LastWriteTimeUtc;
                    if (thisone > reference && !filesCheckedListBox.GetItemChecked(i))
                    {
                        ++checkedCount;
                        filesCheckedListBox.SetItemChecked(i, true);
                    }
                }
            }
            return checkedCount;
        }

        bool interactiveBatch, autoSelectLongestPaths, autoSelectShortestPaths, autoSelectLongestNames, autoSelectShortestNames, autoSelectOldest, autoSelectNewest;
        string requiredText;

        bool FindNextBatchGroup()
        {
            for (;;)
            {
                if (pos >= fileList.Count)
                    return false;

                UpdateList(pos);

                int checkedCount = BatchSelect(pos, requiredText, autoSelectLongestPaths, autoSelectShortestPaths, autoSelectLongestNames, autoSelectShortestNames, autoSelectOldest, autoSelectNewest);

                if (checkedCount > 0 && checkedCount < filesCheckedListBox.Items.Count)
                {
                    return !interactiveBatch;
                }
                else
                {
                    ++pos;
                }
            }
        }

        private void batchButton_Click(object sender, EventArgs e)
        {
            if (interactiveBatch)
                interactiveBatch = false;
            else
            {
                BatchSettingsForm f = new BatchSettingsForm();
                DialogResult res = f.ShowDialog();
                if (res == DialogResult.OK)
                {
                    interactiveBatch = f.InteractiveBatch;
                    requiredText = f.RequiredText.ToUpper();
                    autoSelectLongestPaths = f.AutoSelectLongestPaths;
                    autoSelectShortestPaths = f.AutoSelectShortestPaths;
                    autoSelectLongestNames = f.AutoSelectLongestNames;
                    autoSelectShortestNames = f.AutoSelectShortestNames;
                    autoSelectOldest = f.AutoSelectOldest;
                    autoSelectNewest = f.AutoSelectNewest;

                    pos = 0;
                    UpdateList(0);
                    while (FindNextBatchGroup())
                        Delete();
                }
            }
        }

        private void invertButton_Click(object sender, EventArgs e)
        {
            ArrayList files = (ArrayList)fileList[pos];
            for (int i = 0; i < filesCheckedListBox.Items.Count; i++)
            {
                filesCheckedListBox.SetItemChecked(i, !filesCheckedListBox.GetItemChecked(i));
            }
        }

        private void browse2Button_Click(object sender, EventArgs e)
        {
            BrowsePath(path2TextBox);
        }

        enum Mode { File, Directory };
        Mode mode = Mode.File;

        private void modeButton_Click(object sender, EventArgs e)
        {
            SetMode((mode == Mode.File) ? Mode.Directory : Mode.File);
        }

        void SetMode(Mode m)
        {
            mode = m;
            if (mode == Mode.File)
                limit = fileList.Count - 1;
            else
                limit = directoryList.Count;
            UpdateList(pos = 0);
        }
    }
}