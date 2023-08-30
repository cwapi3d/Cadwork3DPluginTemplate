namespace ProjectWizard
{
    partial class WizardForm
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
            this.doneButton = new System.Windows.Forms.Button();
            this.cleanExitCheckBox = new System.Windows.Forms.CheckBox();
            this.cadworkExecutablePathBrowseButton = new System.Windows.Forms.Button();
            this.cadworkUserprofilePathBrowseButton = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.authorNameTextBox = new System.Windows.Forms.TextBox();
            this.cadworkExecutablePathTextBox = new System.Windows.Forms.TextBox();
            this.cadworkUserprofilePathTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialog2 = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialog3 = new System.Windows.Forms.FolderBrowserDialog();
            this.cadworkExeFromCadworkButton = new System.Windows.Forms.Button();
            this.cadworkUPFromCadworkButton = new System.Windows.Forms.Button();
            this.authorEmailTextBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // doneButton
            // 
            this.doneButton.Location = new System.Drawing.Point(342, 315);
            this.doneButton.Name = "doneButton";
            this.doneButton.Size = new System.Drawing.Size(75, 23);
            this.doneButton.TabIndex = 0;
            this.doneButton.Text = "Done";
            this.doneButton.UseVisualStyleBackColor = true;
            this.doneButton.Click += new System.EventHandler(this.doneButton_Click);
            // 
            // cleanExitCheckBox
            // 
            this.cleanExitCheckBox.AutoSize = true;
            this.cleanExitCheckBox.Checked = true;
            this.cleanExitCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cleanExitCheckBox.Location = new System.Drawing.Point(9, 17);
            this.cleanExitCheckBox.Name = "cleanExitCheckBox";
            this.cleanExitCheckBox.Size = new System.Drawing.Size(338, 17);
            this.cleanExitCheckBox.TabIndex = 1;
            this.cleanExitCheckBox.Text = "My plugin exits and can be unloaded when the init function returns";
            this.cleanExitCheckBox.UseVisualStyleBackColor = true;
            // 
            // cadworkExecutablePathBrowseButton
            // 
            this.cadworkExecutablePathBrowseButton.Location = new System.Drawing.Point(238, 32);
            this.cadworkExecutablePathBrowseButton.Name = "cadworkExecutablePathBrowseButton";
            this.cadworkExecutablePathBrowseButton.Size = new System.Drawing.Size(75, 23);
            this.cadworkExecutablePathBrowseButton.TabIndex = 3;
            this.cadworkExecutablePathBrowseButton.Text = "Browse";
            this.cadworkExecutablePathBrowseButton.UseVisualStyleBackColor = true;
            this.cadworkExecutablePathBrowseButton.Click += new System.EventHandler(this.cadworkExecutablePathBrowseButton_Click);
            // 
            // cadworkUserprofilePathBrowseButton
            // 
            this.cadworkUserprofilePathBrowseButton.Location = new System.Drawing.Point(238, 69);
            this.cadworkUserprofilePathBrowseButton.Name = "cadworkUserprofilePathBrowseButton";
            this.cadworkUserprofilePathBrowseButton.Size = new System.Drawing.Size(75, 23);
            this.cadworkUserprofilePathBrowseButton.TabIndex = 4;
            this.cadworkUserprofilePathBrowseButton.Text = "Browse";
            this.cadworkUserprofilePathBrowseButton.UseVisualStyleBackColor = true;
            this.cadworkUserprofilePathBrowseButton.Click += new System.EventHandler(this.cadworkUserprofilePathBrowseButton_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(14, 320);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(128, 13);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "CwAPI3D Documentation";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Author Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Cadwork Executable Path:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cadwork Userprofile Path:";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.label5.Size = new System.Drawing.Size(405, 35);
            this.label5.TabIndex = 10;
            this.label5.Text = "Cadwork 3D Plugin Configuration";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // authorNameTextBox
            // 
            this.authorNameTextBox.Location = new System.Drawing.Point(9, 32);
            this.authorNameTextBox.Name = "authorNameTextBox";
            this.authorNameTextBox.Size = new System.Drawing.Size(381, 20);
            this.authorNameTextBox.TabIndex = 11;
            // 
            // cadworkExecutablePathTextBox
            // 
            this.cadworkExecutablePathTextBox.Location = new System.Drawing.Point(9, 32);
            this.cadworkExecutablePathTextBox.Name = "cadworkExecutablePathTextBox";
            this.cadworkExecutablePathTextBox.ReadOnly = true;
            this.cadworkExecutablePathTextBox.Size = new System.Drawing.Size(223, 20);
            this.cadworkExecutablePathTextBox.TabIndex = 12;
            // 
            // cadworkUserprofilePathTextBox
            // 
            this.cadworkUserprofilePathTextBox.Location = new System.Drawing.Point(9, 71);
            this.cadworkUserprofilePathTextBox.Name = "cadworkUserprofilePathTextBox";
            this.cadworkUserprofilePathTextBox.ReadOnly = true;
            this.cadworkUserprofilePathTextBox.Size = new System.Drawing.Size(223, 20);
            this.cadworkUserprofilePathTextBox.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.authorEmailTextBox);
            this.groupBox1.Controls.Add(this.authorNameTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(17, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 105);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Plugin Information";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cleanExitCheckBox);
            this.groupBox2.Location = new System.Drawing.Point(17, 269);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(400, 40);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Plugin Configuration";
            // 
            // cadworkExeFromCadworkButton
            // 
            this.cadworkExeFromCadworkButton.Location = new System.Drawing.Point(319, 32);
            this.cadworkExeFromCadworkButton.Name = "cadworkExeFromCadworkButton";
            this.cadworkExeFromCadworkButton.Size = new System.Drawing.Size(75, 23);
            this.cadworkExeFromCadworkButton.TabIndex = 16;
            this.cadworkExeFromCadworkButton.Text = "ci_start";
            this.cadworkExeFromCadworkButton.UseVisualStyleBackColor = true;
            this.cadworkExeFromCadworkButton.Click += new System.EventHandler(this.cadworkExeFromCadworkButton_Click);
            // 
            // cadworkUPFromCadworkButton
            // 
            this.cadworkUPFromCadworkButton.Location = new System.Drawing.Point(319, 69);
            this.cadworkUPFromCadworkButton.Name = "cadworkUPFromCadworkButton";
            this.cadworkUPFromCadworkButton.Size = new System.Drawing.Size(75, 23);
            this.cadworkUPFromCadworkButton.TabIndex = 17;
            this.cadworkUPFromCadworkButton.Text = "ci_start";
            this.cadworkUPFromCadworkButton.UseVisualStyleBackColor = true;
            this.cadworkUPFromCadworkButton.Click += new System.EventHandler(this.cadworkUPFromCadworkButton_Click);
            // 
            // authorEmailTextBox
            // 
            this.authorEmailTextBox.Location = new System.Drawing.Point(9, 75);
            this.authorEmailTextBox.Name = "authorEmailTextBox";
            this.authorEmailTextBox.Size = new System.Drawing.Size(381, 20);
            this.authorEmailTextBox.TabIndex = 18;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cadworkUserprofilePathBrowseButton);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.cadworkExecutablePathBrowseButton);
            this.groupBox3.Controls.Add(this.cadworkExecutablePathTextBox);
            this.groupBox3.Controls.Add(this.cadworkExeFromCadworkButton);
            this.groupBox3.Controls.Add(this.cadworkUPFromCadworkButton);
            this.groupBox3.Controls.Add(this.cadworkUserprofilePathTextBox);
            this.groupBox3.Location = new System.Drawing.Point(17, 158);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(400, 105);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cadwork Configuration";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Author Email:";
            // 
            // WizardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 351);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.doneButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WizardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "WizardForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button doneButton;
        private System.Windows.Forms.CheckBox cleanExitCheckBox;
        private System.Windows.Forms.Button cadworkExecutablePathBrowseButton;
        private System.Windows.Forms.Button cadworkUserprofilePathBrowseButton;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox authorNameTextBox;
        private System.Windows.Forms.TextBox cadworkExecutablePathTextBox;
        private System.Windows.Forms.TextBox cadworkUserprofilePathTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox authorEmailTextBox;
        private System.Windows.Forms.Button cadworkExeFromCadworkButton;
        private System.Windows.Forms.Button cadworkUPFromCadworkButton;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}