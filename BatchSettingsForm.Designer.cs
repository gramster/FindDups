namespace FindDups
{
    partial class BatchSettingsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.requiredStringTextBox = new System.Windows.Forms.TextBox();
            this.interactiveBatchCheckBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ignorePathRadioButton = new System.Windows.Forms.RadioButton();
            this.longestPathRadioButton = new System.Windows.Forms.RadioButton();
            this.shortestPathRadioButton = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ignoreNameLengthRadioButton = new System.Windows.Forms.RadioButton();
            this.longestNameRadioButton = new System.Windows.Forms.RadioButton();
            this.shortestNameRadioButton = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ignoreDateRadioButton = new System.Windows.Forms.RadioButton();
            this.recentlyModifiedRadioButton = new System.Windows.Forms.RadioButton();
            this.leastRecentlyModifiedRadioButton = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 394);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Retained file must contain";
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(89, 496);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "Start";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(206, 496);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // requiredStringTextBox
            // 
            this.requiredStringTextBox.Location = new System.Drawing.Point(181, 387);
            this.requiredStringTextBox.Name = "requiredStringTextBox";
            this.requiredStringTextBox.Size = new System.Drawing.Size(100, 20);
            this.requiredStringTextBox.TabIndex = 3;
            // 
            // interactiveBatchCheckBox
            // 
            this.interactiveBatchCheckBox.AutoSize = true;
            this.interactiveBatchCheckBox.Location = new System.Drawing.Point(55, 456);
            this.interactiveBatchCheckBox.Name = "interactiveBatchCheckBox";
            this.interactiveBatchCheckBox.Size = new System.Drawing.Size(208, 17);
            this.interactiveBatchCheckBox.TabIndex = 4;
            this.interactiveBatchCheckBox.Text = "Just auto-select files; don\'t delete them";
            this.interactiveBatchCheckBox.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 423);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "(Start with \'/\' to specify a regular expression)";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ignorePathRadioButton);
            this.panel1.Controls.Add(this.longestPathRadioButton);
            this.panel1.Controls.Add(this.shortestPathRadioButton);
            this.panel1.Location = new System.Drawing.Point(16, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(329, 92);
            this.panel1.TabIndex = 6;
            // 
            // ignorePathRadioButton
            // 
            this.ignorePathRadioButton.AutoSize = true;
            this.ignorePathRadioButton.Checked = true;
            this.ignorePathRadioButton.Location = new System.Drawing.Point(24, 60);
            this.ignorePathRadioButton.Name = "ignorePathRadioButton";
            this.ignorePathRadioButton.Size = new System.Drawing.Size(171, 17);
            this.ignorePathRadioButton.TabIndex = 2;
            this.ignorePathRadioButton.TabStop = true;
            this.ignorePathRadioButton.Text = "Don\'t use path depth to decide";
            this.ignorePathRadioButton.UseVisualStyleBackColor = true;
            // 
            // longestPathRadioButton
            // 
            this.longestPathRadioButton.AutoSize = true;
            this.longestPathRadioButton.Location = new System.Drawing.Point(24, 36);
            this.longestPathRadioButton.Name = "longestPathRadioButton";
            this.longestPathRadioButton.Size = new System.Drawing.Size(159, 17);
            this.longestPathRadioButton.TabIndex = 1;
            this.longestPathRadioButton.Text = "Retain file with deepest path";
            this.longestPathRadioButton.UseVisualStyleBackColor = true;
            // 
            // shortestPathRadioButton
            // 
            this.shortestPathRadioButton.AutoSize = true;
            this.shortestPathRadioButton.Location = new System.Drawing.Point(24, 12);
            this.shortestPathRadioButton.Name = "shortestPathRadioButton";
            this.shortestPathRadioButton.Size = new System.Drawing.Size(158, 17);
            this.shortestPathRadioButton.TabIndex = 0;
            this.shortestPathRadioButton.Text = "Retain file with shortest path";
            this.shortestPathRadioButton.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ignoreNameLengthRadioButton);
            this.panel2.Controls.Add(this.longestNameRadioButton);
            this.panel2.Controls.Add(this.shortestNameRadioButton);
            this.panel2.Location = new System.Drawing.Point(16, 128);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(329, 107);
            this.panel2.TabIndex = 7;
            // 
            // ignoreNameLengthRadioButton
            // 
            this.ignoreNameLengthRadioButton.AutoSize = true;
            this.ignoreNameLengthRadioButton.Checked = true;
            this.ignoreNameLengthRadioButton.Location = new System.Drawing.Point(24, 65);
            this.ignoreNameLengthRadioButton.Name = "ignoreNameLengthRadioButton";
            this.ignoreNameLengthRadioButton.Size = new System.Drawing.Size(178, 17);
            this.ignoreNameLengthRadioButton.TabIndex = 2;
            this.ignoreNameLengthRadioButton.TabStop = true;
            this.ignoreNameLengthRadioButton.Text = "Don\'t use name length to decide";
            this.ignoreNameLengthRadioButton.UseVisualStyleBackColor = true;
            // 
            // longestNameRadioButton
            // 
            this.longestNameRadioButton.AutoSize = true;
            this.longestNameRadioButton.Location = new System.Drawing.Point(24, 42);
            this.longestNameRadioButton.Name = "longestNameRadioButton";
            this.longestNameRadioButton.Size = new System.Drawing.Size(160, 17);
            this.longestNameRadioButton.TabIndex = 1;
            this.longestNameRadioButton.Text = "Retain file with longest name";
            this.longestNameRadioButton.UseVisualStyleBackColor = true;
            // 
            // shortestNameRadioButton
            // 
            this.shortestNameRadioButton.AutoSize = true;
            this.shortestNameRadioButton.Location = new System.Drawing.Point(24, 19);
            this.shortestNameRadioButton.Name = "shortestNameRadioButton";
            this.shortestNameRadioButton.Size = new System.Drawing.Size(163, 17);
            this.shortestNameRadioButton.TabIndex = 0;
            this.shortestNameRadioButton.Text = "Retain file with shortest name";
            this.shortestNameRadioButton.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ignoreDateRadioButton);
            this.panel3.Controls.Add(this.recentlyModifiedRadioButton);
            this.panel3.Controls.Add(this.leastRecentlyModifiedRadioButton);
            this.panel3.Location = new System.Drawing.Point(16, 256);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(329, 109);
            this.panel3.TabIndex = 8;
            // 
            // ignoreDateRadioButton
            // 
            this.ignoreDateRadioButton.AutoSize = true;
            this.ignoreDateRadioButton.Checked = true;
            this.ignoreDateRadioButton.Location = new System.Drawing.Point(24, 65);
            this.ignoreDateRadioButton.Name = "ignoreDateRadioButton";
            this.ignoreDateRadioButton.Size = new System.Drawing.Size(146, 17);
            this.ignoreDateRadioButton.TabIndex = 2;
            this.ignoreDateRadioButton.TabStop = true;
            this.ignoreDateRadioButton.Text = "Don\'t use dates to decide";
            this.ignoreDateRadioButton.UseVisualStyleBackColor = true;
            // 
            // recentlyModifiedRadioButton
            // 
            this.recentlyModifiedRadioButton.AutoSize = true;
            this.recentlyModifiedRadioButton.Location = new System.Drawing.Point(24, 42);
            this.recentlyModifiedRadioButton.Name = "recentlyModifiedRadioButton";
            this.recentlyModifiedRadioButton.Size = new System.Drawing.Size(179, 17);
            this.recentlyModifiedRadioButton.TabIndex = 1;
            this.recentlyModifiedRadioButton.Text = "Retain file most recently modified";
            this.recentlyModifiedRadioButton.UseVisualStyleBackColor = true;
            // 
            // leastRecentlyModifiedRadioButton
            // 
            this.leastRecentlyModifiedRadioButton.AutoSize = true;
            this.leastRecentlyModifiedRadioButton.Location = new System.Drawing.Point(24, 19);
            this.leastRecentlyModifiedRadioButton.Name = "leastRecentlyModifiedRadioButton";
            this.leastRecentlyModifiedRadioButton.Size = new System.Drawing.Size(179, 17);
            this.leastRecentlyModifiedRadioButton.TabIndex = 0;
            this.leastRecentlyModifiedRadioButton.Text = "Retain file least recently modified";
            this.leastRecentlyModifiedRadioButton.UseVisualStyleBackColor = true;
            // 
            // BatchSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 547);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.interactiveBatchCheckBox);
            this.Controls.Add(this.requiredStringTextBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.label1);
            this.Name = "BatchSettingsForm";
            this.Text = "Batch Settings";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox requiredStringTextBox;
        private System.Windows.Forms.CheckBox interactiveBatchCheckBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton ignorePathRadioButton;
        private System.Windows.Forms.RadioButton longestPathRadioButton;
        private System.Windows.Forms.RadioButton shortestPathRadioButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton ignoreNameLengthRadioButton;
        private System.Windows.Forms.RadioButton longestNameRadioButton;
        private System.Windows.Forms.RadioButton shortestNameRadioButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton ignoreDateRadioButton;
        private System.Windows.Forms.RadioButton recentlyModifiedRadioButton;
        private System.Windows.Forms.RadioButton leastRecentlyModifiedRadioButton;
    }
}