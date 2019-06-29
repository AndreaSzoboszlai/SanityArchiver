namespace SanityArchiver
{
    partial class ListSearchedFiles
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
            this.listSearched = new System.Windows.Forms.ListView();
            this.close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listSearched
            // 
            this.listSearched.Location = new System.Drawing.Point(25, 27);
            this.listSearched.Name = "listSearched";
            this.listSearched.Size = new System.Drawing.Size(359, 474);
            this.listSearched.TabIndex = 0;
            this.listSearched.UseCompatibleStateImageBehavior = false;
            this.listSearched.View = System.Windows.Forms.View.List;
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(106, 521);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(184, 27);
            this.close.TabIndex = 1;
            this.close.Text = "Close";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.Close_Click);
            // 
            // ListSearchedFiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 560);
            this.Controls.Add(this.close);
            this.Controls.Add(this.listSearched);
            this.Name = "ListSearchedFiles";
            this.Text = "ListSearchedFiles";
            this.Load += new System.EventHandler(this.ListSearchedFiles_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listSearched;
        private System.Windows.Forms.Button close;
    }
}