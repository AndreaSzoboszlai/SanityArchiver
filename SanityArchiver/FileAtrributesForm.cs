using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SanityArchiver
{
    public partial class FileAtrributesForm : Form
    {
        public string filePath { get; set; }
        public FileInfo fileSelected;
        List<string> attrList;
        public FileAtrributesForm(String filePath, FileInfo fileSelected)
        {
            InitializeComponent();
            this.filePath = filePath;
            this.fileSelected = fileSelected;

        }

        private List<String> FillWithValues()
        {
            FileAttributes attributes = File.GetAttributes(filePath);
            attrList = new List<string>();
            if ((attributes & FileAttributes.Archive) == FileAttributes.Archive)
            {
                attrList.Add("Archive");
            }

            if ((attributes & FileAttributes.Hidden) == FileAttributes.Hidden)
            {
                attrList.Add("Hidden");
            }

            if ((attributes & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
            {
                attrList.Add("ReadOnly");
            }

            if ((attributes & FileAttributes.NotContentIndexed) == FileAttributes.NotContentIndexed)
            {
                attrList.Add("NotContentIndexed");
            }

            if ((attributes & FileAttributes.Compressed) == FileAttributes.Compressed)
            {
                attrList.Add("Compressed");
            }

            if ((attributes & FileAttributes.Encrypted) == FileAttributes.Encrypted)
            {
                attrList.Add("Encrypted");
            }
            return attrList;
        }

        private void FileAtrributesForm_Load(object sender, EventArgs e)
        {
            selectedFile.Text += filePath;
            List<String> list = FillWithValues();

            for (int i = 0; i < attrCheckBox.Items.Count; i++)
            {
                if (list.Contains(attrCheckBox.Items[i].ToString()))
                {
                    attrCheckBox.SetItemChecked(i, true);
                }
            }
        }

        private void OkAttrButton_Click(object sender, EventArgs e)
        {
            List<string> checkedString = new List<string>();
            for (int i = 0; i < attrCheckBox.Items.Count;i++)
            {
                if (attrCheckBox.GetItemChecked(i))
                {
                    checkedString.Add(attrCheckBox.Items[i].ToString());
                }
            }
            setAttribute(checkedString);
            this.Close();

        }

        private void setAttribute(List<string> checkedString)
        {

            if (!checkedString.Contains(FileAttributes.ReadOnly.ToString()))
            {
                FileAttributes attributes = RemoveAttribute(File.GetAttributes(filePath), FileAttributes.ReadOnly);
                File.SetAttributes(filePath, attributes);
            }
            else
            {
                File.SetAttributes(filePath, File.GetAttributes(filePath) | FileAttributes.ReadOnly);
            }

            if (!checkedString.Contains(FileAttributes.Hidden.ToString()))
            {
                FileAttributes attributes = RemoveAttribute(File.GetAttributes(filePath), FileAttributes.Hidden);
                File.SetAttributes(filePath, attributes);
            }
            else
            {
                File.SetAttributes(filePath, File.GetAttributes(filePath) | FileAttributes.Hidden);
            }

            if (!checkedString.Contains(FileAttributes.Archive.ToString()))
            {
                FileAttributes attributes = RemoveAttribute(File.GetAttributes(filePath), FileAttributes.Archive);
                File.SetAttributes(filePath, attributes);
            }
            else
            {
                File.SetAttributes(filePath, File.GetAttributes(filePath) | FileAttributes.Archive);
            }

            if (!checkedString.Contains(FileAttributes.NotContentIndexed.ToString())) 
                {
                FileAttributes attributes = RemoveAttribute(File.GetAttributes(filePath), FileAttributes.NotContentIndexed);
                File.SetAttributes(filePath, attributes);
            }
            else
            {
                File.SetAttributes(filePath, File.GetAttributes(filePath) | FileAttributes.NotContentIndexed);
            }

            if (!checkedString.Contains(FileAttributes.Encrypted.ToString()))
            {
                FileAttributes attributes = RemoveAttribute(File.GetAttributes(filePath), FileAttributes.Encrypted);
                File.SetAttributes(filePath, attributes);
            }
            else
            {
                File.SetAttributes(filePath, File.GetAttributes(filePath) | FileAttributes.Encrypted);
            }

        }

        private static FileAttributes RemoveAttribute(FileAttributes attributes, FileAttributes attributesToRemove)
        {
            return attributes & ~attributesToRemove;
        }
    }
}
