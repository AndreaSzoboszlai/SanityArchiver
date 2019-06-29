namespace SanityArchiver
{
    partial class FileAtrributesForm
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
            this.selectedFile = new System.Windows.Forms.Label();
            this.okAttrButton = new System.Windows.Forms.Button();
            this.attrCheckBox = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // selectedFile
            // 
            this.selectedFile.Location = new System.Drawing.Point(12, 37);
            this.selectedFile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.selectedFile.Name = "selectedFile";
            this.selectedFile.Size = new System.Drawing.Size(116, 20);
            this.selectedFile.TabIndex = 0;
            this.selectedFile.Text = "Selected File: ";
            // 
            // okAttrButton
            // 
            this.okAttrButton.Location = new System.Drawing.Point(60, 249);
            this.okAttrButton.Margin = new System.Windows.Forms.Padding(4);
            this.okAttrButton.Name = "okAttrButton";
            this.okAttrButton.Size = new System.Drawing.Size(201, 38);
            this.okAttrButton.TabIndex = 1;
            this.okAttrButton.Text = "Save changes";
            this.okAttrButton.UseVisualStyleBackColor = true;
            this.okAttrButton.Click += new System.EventHandler(this.OkAttrButton_Click);
            // 
            // attrCheckBox
            // 
            this.attrCheckBox.BackColor = System.Drawing.SystemColors.Control;
            this.attrCheckBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.attrCheckBox.FormattingEnabled = true;
            this.attrCheckBox.Items.AddRange(new object[] {
            "ReadOnly",
            "Hidden",
            "Archive",
            "NotContentIndexed",
            "Encrypted"});
            this.attrCheckBox.Location = new System.Drawing.Point(75, 119);
            this.attrCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.attrCheckBox.Name = "attrCheckBox";
            this.attrCheckBox.Size = new System.Drawing.Size(201, 110);
            this.attrCheckBox.TabIndex = 2;
            // 
            // FileAtrributesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 300);
            this.Controls.Add(this.attrCheckBox);
            this.Controls.Add(this.okAttrButton);
            this.Controls.Add(this.selectedFile);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FileAtrributesForm";
            this.Text = "FileAtrributesForm";
            this.Load += new System.EventHandler(this.FileAtrributesForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label selectedFile;
        private System.Windows.Forms.Button okAttrButton;
        private System.Windows.Forms.CheckedListBox attrCheckBox;
    }
}