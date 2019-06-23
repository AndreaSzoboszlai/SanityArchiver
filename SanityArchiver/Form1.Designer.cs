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
            // 
            // SanityArchiver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 450);
            this.Controls.Add(this.editProps);
            this.Controls.Add(this.compressing);
            this.Controls.Add(this.openSelected);
            this.Controls.Add(this.browse);
            this.Controls.Add(this.textBox1);
            this.Name = "SanityArchiver";
            this.Text = "Sanity Archiver";
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
    }
}

