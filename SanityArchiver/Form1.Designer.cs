namespace SanityArchiver
{
    partial class SanityArchiver
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
            this.openFileBrowser = new System.Windows.Forms.OpenFileDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.browse = new System.Windows.Forms.Button();
            this.openSelected = new System.Windows.Forms.Button();
            this.compressing = new System.Windows.Forms.Button();
            this.editProps = new System.Windows.Forms.Button();
            this.encription = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.browseCopyFile = new System.Windows.Forms.Button();
            this.destenationFolder = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.copied = new System.Windows.Forms.Label();
            this.folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.copyFile = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileBrowser
            // 
            this.openFileBrowser.FileName = "openFileBrowser";
            this.openFileBrowser.InitialDirectory = "C:\\";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(305, 22);
            this.textBox1.TabIndex = 0;
            // 
            // browse
            // 
            this.browse.Location = new System.Drawing.Point(84, 46);
            this.browse.Name = "browse";
            this.browse.Size = new System.Drawing.Size(156, 31);
            this.browse.TabIndex = 1;
            this.browse.Text = "Browse files";
            this.browse.UseVisualStyleBackColor = true;
            this.browse.Click += new System.EventHandler(this.Browse_Click);
            // 
            // openSelected
            // 
            this.openSelected.Location = new System.Drawing.Point(84, 94);
            this.openSelected.Name = "openSelected";
            this.openSelected.Size = new System.Drawing.Size(156, 31);
            this.openSelected.TabIndex = 2;
            this.openSelected.Text = "Open Selected File";
            this.openSelected.UseVisualStyleBackColor = true;
            this.openSelected.Click += new System.EventHandler(this.OpenSelected_Click);
            // 
            // compressing
            // 
            this.compressing.Location = new System.Drawing.Point(84, 143);
            this.compressing.Name = "compressing";
            this.compressing.Size = new System.Drawing.Size(156, 31);
            this.compressing.TabIndex = 3;
            this.compressing.Text = "Compressing File";
            this.compressing.UseVisualStyleBackColor = true;
            this.compressing.Click += new System.EventHandler(this.Compressing_Click);
            // 
            // editProps
            // 
            this.editProps.Location = new System.Drawing.Point(84, 190);
            this.editProps.Name = "editProps";
            this.editProps.Size = new System.Drawing.Size(156, 31);
            this.editProps.TabIndex = 4;
            this.editProps.Text = "Edit Properties";
            this.editProps.UseVisualStyleBackColor = true;
            this.editProps.Click += new System.EventHandler(this.EditProps_Click);
            // 
            // encription
            // 
            this.encription.Location = new System.Drawing.Point(84, 236);
            this.encription.Name = "encription";
            this.encription.Size = new System.Drawing.Size(156, 31);
            this.encription.TabIndex = 5;
            this.encription.Text = "Encription";
            this.encription.UseVisualStyleBackColor = true;
            this.encription.Click += new System.EventHandler(this.Encription_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(19, 31);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(305, 22);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(19, 106);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(305, 22);
            this.textBox3.TabIndex = 7;
            // 
            // browseCopyFile
            // 
            this.browseCopyFile.Location = new System.Drawing.Point(97, 59);
            this.browseCopyFile.Name = "browseCopyFile";
            this.browseCopyFile.Size = new System.Drawing.Size(156, 31);
            this.browseCopyFile.TabIndex = 8;
            this.browseCopyFile.Text = "Browse files";
            this.browseCopyFile.UseVisualStyleBackColor = true;
            this.browseCopyFile.Click += new System.EventHandler(this.BrowseCopyFile_Click);
            // 
            // destenationFolder
            // 
            this.destenationFolder.Location = new System.Drawing.Point(97, 134);
            this.destenationFolder.Name = "destenationFolder";
            this.destenationFolder.Size = new System.Drawing.Size(156, 31);
            this.destenationFolder.TabIndex = 9;
            this.destenationFolder.Text = "Browse files";
            this.destenationFolder.UseVisualStyleBackColor = true;
            this.destenationFolder.Click += new System.EventHandler(this.DestenationFolder_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.copied);
            this.groupBox1.Controls.Add(this.copyFile);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.destenationFolder);
            this.groupBox1.Controls.Add(this.browseCopyFile);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Location = new System.Drawing.Point(370, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 241);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Copy File";
            // 
            // copied
            // 
            this.copied.AutoSize = true;
            this.copied.Location = new System.Drawing.Point(150, 211);
            this.copied.Name = "copied";
            this.copied.Size = new System.Drawing.Size(0, 17);
            this.copied.TabIndex = 10;
            // 
            // folderBrowser
            // 
            this.folderBrowser.SelectedPath = "C:\\";
            // 
            // copyFile
            // 
            this.copyFile.Location = new System.Drawing.Point(58, 177);
            this.copyFile.Name = "copyFile";
            this.copyFile.Size = new System.Drawing.Size(229, 31);
            this.copyFile.TabIndex = 10;
            this.copyFile.Text = "Copy file";
            this.copyFile.UseVisualStyleBackColor = true;
            this.copyFile.Click += new System.EventHandler(this.CopyFile_Click);
            // 
            // SanityArchiver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.encription);
            this.Controls.Add(this.editProps);
            this.Controls.Add(this.compressing);
            this.Controls.Add(this.openSelected);
            this.Controls.Add(this.browse);
            this.Controls.Add(this.textBox1);
            this.Name = "SanityArchiver";
            this.Text = "Sanity Archiver";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileBrowser;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button browse;
        private System.Windows.Forms.Button openSelected;
        private System.Windows.Forms.Button compressing;
        private System.Windows.Forms.Button editProps;
        private System.Windows.Forms.Button encription;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button browseCopyFile;
        private System.Windows.Forms.Button destenationFolder;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label copied;
        private System.Windows.Forms.FolderBrowserDialog folderBrowser;
        private System.Windows.Forms.Button copyFile;
    }
}

