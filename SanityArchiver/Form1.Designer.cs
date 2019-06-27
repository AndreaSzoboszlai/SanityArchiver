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
            this.moveFile = new System.Windows.Forms.Button();
            this.copied = new System.Windows.Forms.Label();
            this.copyFile = new System.Windows.Forms.Button();
            this.folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.calculateSize = new System.Windows.Forms.Button();
            this.browseFolders = new System.Windows.Forms.Button();
            this.sizeOfDirectory = new System.Windows.Forms.GroupBox();
            this.sizeOfChoosenDirectory = new System.Windows.Forms.Label();
            this.choosenFolder = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.sizeOfDirectory.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileBrowser
            // 
            this.openFileBrowser.FileName = "openFileBrowser";
            this.openFileBrowser.InitialDirectory = "C:\\";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(305, 22);
            this.textBox1.TabIndex = 0;
            // 
            // browse
            // 
            this.browse.Location = new System.Drawing.Point(77, 64);
            this.browse.Name = "browse";
            this.browse.Size = new System.Drawing.Size(156, 31);
            this.browse.TabIndex = 1;
            this.browse.Text = "Browse files";
            this.browse.UseVisualStyleBackColor = true;
            this.browse.Click += new System.EventHandler(this.Browse_Click);
            // 
            // openSelected
            // 
            this.openSelected.Location = new System.Drawing.Point(77, 112);
            this.openSelected.Name = "openSelected";
            this.openSelected.Size = new System.Drawing.Size(156, 31);
            this.openSelected.TabIndex = 2;
            this.openSelected.Text = "Open Selected File";
            this.openSelected.UseVisualStyleBackColor = true;
            this.openSelected.Click += new System.EventHandler(this.OpenSelected_Click);
            // 
            // compressing
            // 
            this.compressing.Location = new System.Drawing.Point(77, 161);
            this.compressing.Name = "compressing";
            this.compressing.Size = new System.Drawing.Size(156, 31);
            this.compressing.TabIndex = 3;
            this.compressing.Text = "Compressing File";
            this.compressing.UseVisualStyleBackColor = true;
            // 
            // editProps
            // 
            this.editProps.Location = new System.Drawing.Point(77, 208);
            this.editProps.Name = "editProps";
            this.editProps.Size = new System.Drawing.Size(156, 31);
            this.editProps.TabIndex = 4;
            this.editProps.Text = "Edit Properties";
            this.editProps.UseVisualStyleBackColor = true;
            // 
            // encription
            // 
            this.encription.Location = new System.Drawing.Point(77, 254);
            this.encription.Name = "encription";
            this.encription.Size = new System.Drawing.Size(156, 31);
            this.encription.TabIndex = 5;
            this.encription.Text = "Encription";
            this.encription.UseVisualStyleBackColor = true;
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
            // 
            // destenationFolder
            // 
            this.destenationFolder.Location = new System.Drawing.Point(97, 134);
            this.destenationFolder.Name = "destenationFolder";
            this.destenationFolder.Size = new System.Drawing.Size(156, 31);
            this.destenationFolder.TabIndex = 9;
            this.destenationFolder.Text = "Browse files";
            this.destenationFolder.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.moveFile);
            this.groupBox1.Controls.Add(this.copied);
            this.groupBox1.Controls.Add(this.copyFile);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.destenationFolder);
            this.groupBox1.Controls.Add(this.browseCopyFile);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Location = new System.Drawing.Point(370, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 285);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Copy or Move File";
            // 
            // moveFile
            // 
            this.moveFile.Location = new System.Drawing.Point(58, 214);
            this.moveFile.Name = "moveFile";
            this.moveFile.Size = new System.Drawing.Size(229, 31);
            this.moveFile.TabIndex = 11;
            this.moveFile.Text = "Move file";
            this.moveFile.UseVisualStyleBackColor = true;
            // 
            // copied
            // 
            this.copied.AutoSize = true;
            this.copied.Location = new System.Drawing.Point(94, 254);
            this.copied.Name = "copied";
            this.copied.Size = new System.Drawing.Size(0, 17);
            this.copied.TabIndex = 10;
            // 
            // copyFile
            // 
            this.copyFile.Location = new System.Drawing.Point(58, 177);
            this.copyFile.Name = "copyFile";
            this.copyFile.Size = new System.Drawing.Size(229, 31);
            this.copyFile.TabIndex = 10;
            this.copyFile.Text = "Copy file";
            this.copyFile.UseVisualStyleBackColor = true;
            // 
            // folderBrowser
            // 
            this.folderBrowser.SelectedPath = "C:\\";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.browse);
            this.groupBox2.Controls.Add(this.encription);
            this.groupBox2.Controls.Add(this.openSelected);
            this.groupBox2.Controls.Add(this.editProps);
            this.groupBox2.Controls.Add(this.compressing);
            this.groupBox2.Location = new System.Drawing.Point(23, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(329, 308);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select and Modify Files";
            // 
            // calculateSize
            // 
            this.calculateSize.Location = new System.Drawing.Point(162, 51);
            this.calculateSize.Name = "calculateSize";
            this.calculateSize.Size = new System.Drawing.Size(112, 31);
            this.calculateSize.TabIndex = 6;
            this.calculateSize.Text = "Calculate Size";
            this.calculateSize.UseVisualStyleBackColor = true;
            // 
            // browseFolders
            // 
            this.browseFolders.Location = new System.Drawing.Point(44, 51);
            this.browseFolders.Name = "browseFolders";
            this.browseFolders.Size = new System.Drawing.Size(112, 31);
            this.browseFolders.TabIndex = 12;
            this.browseFolders.Text = "Browse files";
            this.browseFolders.UseVisualStyleBackColor = true;
            // 
            // sizeOfDirectory
            // 
            this.sizeOfDirectory.Controls.Add(this.sizeOfChoosenDirectory);
            this.sizeOfDirectory.Controls.Add(this.choosenFolder);
            this.sizeOfDirectory.Controls.Add(this.browseFolders);
            this.sizeOfDirectory.Controls.Add(this.calculateSize);
            this.sizeOfDirectory.Location = new System.Drawing.Point(29, 337);
            this.sizeOfDirectory.Name = "sizeOfDirectory";
            this.sizeOfDirectory.Size = new System.Drawing.Size(323, 124);
            this.sizeOfDirectory.TabIndex = 13;
            this.sizeOfDirectory.TabStop = false;
            this.sizeOfDirectory.Text = "Size Of Choosen Directory";
            // 
            // sizeOfChoosenDirectory
            // 
            this.sizeOfChoosenDirectory.AutoSize = true;
            this.sizeOfChoosenDirectory.Location = new System.Drawing.Point(83, 95);
            this.sizeOfChoosenDirectory.Name = "sizeOfChoosenDirectory";
            this.sizeOfChoosenDirectory.Size = new System.Drawing.Size(0, 17);
            this.sizeOfChoosenDirectory.TabIndex = 12;
            // 
            // choosenFolder
            // 
            this.choosenFolder.Location = new System.Drawing.Point(12, 23);
            this.choosenFolder.Name = "choosenFolder";
            this.choosenFolder.Size = new System.Drawing.Size(305, 22);
            this.choosenFolder.TabIndex = 12;
            // 
            // SanityArchiver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 500);
            this.Controls.Add(this.sizeOfDirectory);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "SanityArchiver";
            this.Text = "Sanity Archiver";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.sizeOfDirectory.ResumeLayout(false);
            this.sizeOfDirectory.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button moveFile;
        private System.Windows.Forms.Button calculateSize;
        private System.Windows.Forms.Button browseFolders;
        private System.Windows.Forms.GroupBox sizeOfDirectory;
        private System.Windows.Forms.Label sizeOfChoosenDirectory;
        private System.Windows.Forms.TextBox choosenFolder;
    }
}

