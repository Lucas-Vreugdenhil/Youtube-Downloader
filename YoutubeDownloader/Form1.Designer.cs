
namespace YoutubeDownloader
{
    partial class Form1
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
            this.txtLink = new System.Windows.Forms.TextBox();
            this.cbxFileType = new System.Windows.Forms.ComboBox();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnSelectFolder = new System.Windows.Forms.Button();
            this.btnSetDefaultPath = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Youtube Link:";
            // 
            // txtLink
            // 
            this.txtLink.Location = new System.Drawing.Point(16, 30);
            this.txtLink.Name = "txtLink";
            this.txtLink.Size = new System.Drawing.Size(355, 20);
            this.txtLink.TabIndex = 1;
            // 
            // cbxFileType
            // 
            this.cbxFileType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFileType.FormattingEnabled = true;
            this.cbxFileType.Items.AddRange(new object[] {
            ".mp4",
            ".mp3"});
            this.cbxFileType.Location = new System.Drawing.Point(291, 74);
            this.cbxFileType.Name = "cbxFileType";
            this.cbxFileType.Size = new System.Drawing.Size(75, 21);
            this.cbxFileType.TabIndex = 2;
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(16, 74);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(182, 20);
            this.txtPath.TabIndex = 3;
            this.txtPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Save as:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(293, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Filetype:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(291, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Download";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.Location = new System.Drawing.Point(204, 72);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Size = new System.Drawing.Size(78, 23);
            this.btnSelectFolder.TabIndex = 7;
            this.btnSelectFolder.Text = "Select Folder";
            this.btnSelectFolder.UseVisualStyleBackColor = true;
            this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click);
            // 
            // btnSetDefaultPath
            // 
            this.btnSetDefaultPath.Location = new System.Drawing.Point(171, 100);
            this.btnSetDefaultPath.Name = "btnSetDefaultPath";
            this.btnSetDefaultPath.Size = new System.Drawing.Size(111, 23);
            this.btnSetDefaultPath.TabIndex = 8;
            this.btnSetDefaultPath.Text = "Set as default path";
            this.btnSetDefaultPath.UseVisualStyleBackColor = true;
            this.btnSetDefaultPath.Click += new System.EventHandler(this.btnSetDefaultPath_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 153);
            this.Controls.Add(this.btnSetDefaultPath);
            this.Controls.Add(this.btnSelectFolder);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.cbxFileType);
            this.Controls.Add(this.txtLink);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Youtube Converter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLink;
        private System.Windows.Forms.ComboBox cbxFileType;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnSelectFolder;
        private System.Windows.Forms.Button btnSetDefaultPath;
    }
}

