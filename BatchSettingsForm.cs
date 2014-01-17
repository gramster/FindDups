using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FindDups
{
    public partial class BatchSettingsForm : Form
    {
        public string RequiredText = string.Empty;
        public bool InteractiveBatch = true;
        public bool AutoSelectShortestPaths = false;
        public bool AutoSelectLongestPaths = false;
        public bool AutoSelectShortestNames = false;
        public bool AutoSelectLongestNames = false;
        public bool AutoSelectOldest = false;
        public bool AutoSelectNewest = false;

        public BatchSettingsForm()
        {
            InitializeComponent();
            interactiveBatchCheckBox.Checked = InteractiveBatch;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RequiredText = requiredStringTextBox.Text;
            InteractiveBatch = interactiveBatchCheckBox.Checked;
            AutoSelectLongestPaths = shortestPathRadioButton.Checked;
            AutoSelectShortestPaths = longestPathRadioButton.Checked;
            AutoSelectLongestNames = shortestNameRadioButton.Checked;
            AutoSelectShortestNames = longestNameRadioButton.Checked;
            AutoSelectOldest = leastRecentlyModifiedRadioButton.Checked;
            AutoSelectNewest = recentlyModifiedRadioButton.Checked;

            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            InteractiveBatch = false;
            Close();
        }

    }
}