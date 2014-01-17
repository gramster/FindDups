namespace FindDups
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.browse1Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.path1TextBox = new System.Windows.Forms.TextBox();
            this.filesCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.prevButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.checkAllButton = new System.Windows.Forms.Button();
            this.checkNoneButton = new System.Windows.Forms.Button();
            this.checkOlderButton = new System.Windows.Forms.Button();
            this.checkNewerButton = new System.Windows.Forms.Button();
            this.fileSizeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.batchButton = new System.Windows.Forms.Button();
            this.invertButton = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.suffixTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.path2TextBox = new System.Windows.Forms.TextBox();
            this.browse2Button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.modeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fileSizeNumericUpDown)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // browse1Button
            // 
            this.browse1Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.browse1Button.Location = new System.Drawing.Point(361, 20);
            this.browse1Button.Name = "browse1Button";
            this.browse1Button.Size = new System.Drawing.Size(75, 23);
            this.browse1Button.TabIndex = 0;
            this.browse1Button.Text = "Browse";
            this.browse1Button.UseVisualStyleBackColor = true;
            this.browse1Button.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Directory1";
            // 
            // path1TextBox
            // 
            this.path1TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.path1TextBox.Location = new System.Drawing.Point(65, 22);
            this.path1TextBox.Name = "path1TextBox";
            this.path1TextBox.Size = new System.Drawing.Size(290, 20);
            this.path1TextBox.TabIndex = 2;
            this.path1TextBox.TextChanged += new System.EventHandler(this.pathTextBox_TextChanged);
            // 
            // filesCheckedListBox
            // 
            this.filesCheckedListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.filesCheckedListBox.FormattingEnabled = true;
            this.filesCheckedListBox.HorizontalScrollbar = true;
            this.filesCheckedListBox.Location = new System.Drawing.Point(25, 144);
            this.filesCheckedListBox.Name = "filesCheckedListBox";
            this.filesCheckedListBox.Size = new System.Drawing.Size(423, 139);
            this.filesCheckedListBox.TabIndex = 3;
            this.filesCheckedListBox.SelectedIndexChanged += new System.EventHandler(this.filesCheckedListBox_SelectedIndexChanged);
            this.filesCheckedListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.filesCheckedListBox_ItemCheck);
            // 
            // prevButton
            // 
            this.prevButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.prevButton.Enabled = false;
            this.prevButton.Location = new System.Drawing.Point(13, 19);
            this.prevButton.Name = "prevButton";
            this.prevButton.Size = new System.Drawing.Size(81, 23);
            this.prevButton.TabIndex = 4;
            this.prevButton.Text = "Prev";
            this.toolTip1.SetToolTip(this.prevButton, "Move to previous set of matches");
            this.prevButton.UseVisualStyleBackColor = true;
            this.prevButton.Click += new System.EventHandler(this.prevButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.nextButton.Enabled = false;
            this.nextButton.Location = new System.Drawing.Point(98, 19);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(81, 23);
            this.nextButton.TabIndex = 5;
            this.nextButton.Text = "Next";
            this.toolTip1.SetToolTip(this.nextButton, "Move to next set of matches");
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.deleteButton.Enabled = false;
            this.deleteButton.Location = new System.Drawing.Point(183, 19);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(81, 23);
            this.deleteButton.TabIndex = 6;
            this.deleteButton.Text = "Delete";
            this.toolTip1.SetToolTip(this.deleteButton, "Delete all checked files and advance to next set");
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.exitButton.Location = new System.Drawing.Point(353, 19);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(81, 23);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.toolTip1.SetToolTip(this.exitButton, "Exit the application");
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // checkAllButton
            // 
            this.checkAllButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkAllButton.Enabled = false;
            this.checkAllButton.Location = new System.Drawing.Point(13, 27);
            this.checkAllButton.Name = "checkAllButton";
            this.checkAllButton.Size = new System.Drawing.Size(81, 23);
            this.checkAllButton.TabIndex = 10;
            this.checkAllButton.Text = "All";
            this.toolTip1.SetToolTip(this.checkAllButton, "Check all files");
            this.checkAllButton.UseVisualStyleBackColor = true;
            this.checkAllButton.Click += new System.EventHandler(this.checkAllButton_Click);
            // 
            // checkNoneButton
            // 
            this.checkNoneButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkNoneButton.Enabled = false;
            this.checkNoneButton.Location = new System.Drawing.Point(98, 27);
            this.checkNoneButton.Name = "checkNoneButton";
            this.checkNoneButton.Size = new System.Drawing.Size(81, 23);
            this.checkNoneButton.TabIndex = 11;
            this.checkNoneButton.Text = "None";
            this.toolTip1.SetToolTip(this.checkNoneButton, "Uncheck all files");
            this.checkNoneButton.UseVisualStyleBackColor = true;
            this.checkNoneButton.Click += new System.EventHandler(this.checkNoneButton_Click);
            // 
            // checkOlderButton
            // 
            this.checkOlderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkOlderButton.Enabled = false;
            this.checkOlderButton.Location = new System.Drawing.Point(183, 27);
            this.checkOlderButton.Name = "checkOlderButton";
            this.checkOlderButton.Size = new System.Drawing.Size(81, 23);
            this.checkOlderButton.TabIndex = 12;
            this.checkOlderButton.Text = "Older";
            this.toolTip1.SetToolTip(this.checkOlderButton, "Check all but the newest file");
            this.checkOlderButton.UseVisualStyleBackColor = true;
            this.checkOlderButton.Click += new System.EventHandler(this.checkOlderButton_Click);
            // 
            // checkNewerButton
            // 
            this.checkNewerButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkNewerButton.Enabled = false;
            this.checkNewerButton.Location = new System.Drawing.Point(268, 27);
            this.checkNewerButton.Name = "checkNewerButton";
            this.checkNewerButton.Size = new System.Drawing.Size(81, 23);
            this.checkNewerButton.TabIndex = 13;
            this.checkNewerButton.Text = "Newer";
            this.toolTip1.SetToolTip(this.checkNewerButton, "Check all but the oldest file");
            this.checkNewerButton.UseVisualStyleBackColor = true;
            this.checkNewerButton.Click += new System.EventHandler(this.checkNewerButton_Click);
            // 
            // fileSizeNumericUpDown
            // 
            this.fileSizeNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fileSizeNumericUpDown.Location = new System.Drawing.Point(346, 91);
            this.fileSizeNumericUpDown.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.fileSizeNumericUpDown.Name = "fileSizeNumericUpDown";
            this.fileSizeNumericUpDown.Size = new System.Drawing.Size(89, 20);
            this.fileSizeNumericUpDown.TabIndex = 17;
            this.toolTip1.SetToolTip(this.fileSizeNumericUpDown, "Minimum files size in bytes");
            this.fileSizeNumericUpDown.ValueChanged += new System.EventHandler(this.fileSizeNumericUpDown_ValueChanged);
            // 
            // batchButton
            // 
            this.batchButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.batchButton.Enabled = false;
            this.batchButton.Location = new System.Drawing.Point(268, 19);
            this.batchButton.Name = "batchButton";
            this.batchButton.Size = new System.Drawing.Size(81, 23);
            this.batchButton.TabIndex = 18;
            this.batchButton.Text = "Batch";
            this.toolTip1.SetToolTip(this.batchButton, "Clean up multiple sets in one operation");
            this.batchButton.UseVisualStyleBackColor = true;
            this.batchButton.Click += new System.EventHandler(this.batchButton_Click);
            // 
            // invertButton
            // 
            this.invertButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.invertButton.Enabled = false;
            this.invertButton.Location = new System.Drawing.Point(353, 27);
            this.invertButton.Name = "invertButton";
            this.invertButton.Size = new System.Drawing.Size(81, 23);
            this.invertButton.TabIndex = 19;
            this.invertButton.Text = "Invert";
            this.toolTip1.SetToolTip(this.invertButton, "Invert the current selection");
            this.invertButton.UseVisualStyleBackColor = true;
            this.invertButton.Click += new System.EventHandler(this.invertButton_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel,
            this.toolStripProgressBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 438);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(472, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripProgressBar
            // 
            this.toolStripProgressBar.Name = "toolStripProgressBar";
            this.toolStripProgressBar.Size = new System.Drawing.Size(100, 16);
            this.toolStripProgressBar.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Only filenames ending with";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(235, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Only files as big as";
            // 
            // suffixTextBox
            // 
            this.suffixTextBox.Location = new System.Drawing.Point(150, 91);
            this.suffixTextBox.Name = "suffixTextBox";
            this.suffixTextBox.Size = new System.Drawing.Size(66, 20);
            this.suffixTextBox.TabIndex = 16;
            this.suffixTextBox.TextChanged += new System.EventHandler(this.suffixTextBox_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkOlderButton);
            this.groupBox1.Controls.Add(this.invertButton);
            this.groupBox1.Controls.Add(this.checkAllButton);
            this.groupBox1.Controls.Add(this.checkNoneButton);
            this.groupBox1.Controls.Add(this.checkNewerButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 272);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(448, 65);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selection";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.deleteButton);
            this.groupBox2.Controls.Add(this.prevButton);
            this.groupBox2.Controls.Add(this.batchButton);
            this.groupBox2.Controls.Add(this.nextButton);
            this.groupBox2.Controls.Add(this.exitButton);
            this.groupBox2.Location = new System.Drawing.Point(12, 343);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(448, 58);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Action";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.path2TextBox);
            this.groupBox3.Controls.Add(this.browse2Button);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.browse1Button);
            this.groupBox3.Controls.Add(this.path1TextBox);
            this.groupBox3.Controls.Add(this.fileSizeNumericUpDown);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.suffixTextBox);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(448, 128);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Source Files";
            // 
            // path2TextBox
            // 
            this.path2TextBox.Location = new System.Drawing.Point(119, 56);
            this.path2TextBox.Name = "path2TextBox";
            this.path2TextBox.Size = new System.Drawing.Size(236, 20);
            this.path2TextBox.TabIndex = 20;
            // 
            // browse2Button
            // 
            this.browse2Button.Location = new System.Drawing.Point(361, 56);
            this.browse2Button.Name = "browse2Button";
            this.browse2Button.Size = new System.Drawing.Size(75, 23);
            this.browse2Button.TabIndex = 19;
            this.browse2Button.Text = "Browse";
            this.browse2Button.UseVisualStyleBackColor = true;
            this.browse2Button.Click += new System.EventHandler(this.browse2Button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "(Optional) Directory2";
            // 
            // modeButton
            // 
            this.modeButton.Location = new System.Drawing.Point(25, 407);
            this.modeButton.Name = "modeButton";
            this.modeButton.Size = new System.Drawing.Size(166, 23);
            this.modeButton.TabIndex = 23;
            this.modeButton.Text = "Directory Mode";
            this.modeButton.UseVisualStyleBackColor = true;
            this.modeButton.Click += new System.EventHandler(this.modeButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 460);
            this.Controls.Add(this.modeButton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.filesCheckedListBox);
            this.MinimumSize = new System.Drawing.Size(480, 380);
            this.Name = "MainForm";
            this.Text = "RemoveDups";
            ((System.ComponentModel.ISupportInitialize)(this.fileSizeNumericUpDown)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button browse1Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox path1TextBox;
        private System.Windows.Forms.CheckedListBox filesCheckedListBox;
        private System.Windows.Forms.Button prevButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar;
        private System.Windows.Forms.Button checkAllButton;
        private System.Windows.Forms.Button checkNoneButton;
        private System.Windows.Forms.Button checkOlderButton;
        private System.Windows.Forms.Button checkNewerButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox suffixTextBox;
        private System.Windows.Forms.NumericUpDown fileSizeNumericUpDown;
        private System.Windows.Forms.Button batchButton;
        private System.Windows.Forms.Button invertButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox path2TextBox;
        private System.Windows.Forms.Button browse2Button;
        private System.Windows.Forms.Button modeButton;
    }
}

