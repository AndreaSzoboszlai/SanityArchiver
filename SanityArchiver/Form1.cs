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
using System.IO.Compression;

namespace SanityArchiver
{
    public partial class SanityArchiver : Form
    {
        string selected;
        FileInfo fileSelected;
        string selectedCopy;
        string selectedFolder;
        public SanityArchiver()
        {
            InitializeComponent();
        }

        private void Browse_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileBrowser.ShowDialog();
            if (result == DialogResult.OK)
            {
                selected = openFileBrowser.FileName;
                textBox1.Text = selected;
                fileSelected = new FileInfo(selected);
                if (fileSelected.Extension != ".gz")
                {
                    compressing.Text = "Compress File";
                }
                else
                {
                    compressing.Text = "Decompress File";
                }

                CheckEncryption();
            }
        }

        private void OpenSelected_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(choosenFolder.Text))
            {
                System.Diagnostics.Process.Start(selected);

            }
        }
        private void Compressing_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(choosenFolder.Text))
            {
                fileSelected = new FileInfo(selected);
                if (fileSelected.Extension != ".gz")
                {
                    Compress();
                }
                else
                {
                    DeCompress();
                }
            }

        }

        public void Compress()
        {
            FileInfo fileSelectedFrom = new FileInfo(selected);
            FileInfo fileSelectedTo = new FileInfo(selected);
            FileStream input = fileSelectedTo.OpenRead();
            FileStream output = File.Create(fileSelectedFrom.FullName + ".gz");
            GZipStream Compressor = new GZipStream(output, CompressionMode.Compress);
            int b = input.ReadByte();
            while (b != -1)
            {
                Compressor.WriteByte((byte)b);
                b = input.ReadByte();
            }
            Compressor.Close();
            input.Close();
            output.Close();
        }

        public void DeCompress()
        {
            FileInfo fileSelectedTo = new FileInfo(selected.Remove(selected.Length - fileSelected.Extension.Length));
            FileInfo fileSelectedFrom = new FileInfo(selected);
            FileStream input = fileSelectedFrom.OpenRead();
            FileStream output = File.Create(Path.GetDirectoryName(selected) + "\\" + @"" + fileSelectedTo.Name);
            GZipStream deCompressor = new GZipStream(input, CompressionMode.Decompress);

            deCompressor.CopyTo(output);

            deCompressor.Close();
            input.Close();
            output.Close();
        }

        private void EditProps_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Needs implementing.");
        }

        public static void AddEncryption(string FileName)
        {

            File.Encrypt(FileName);

        }

        // Decrypt a file.
        public static void RemoveEncryption(string FileName)
        {
            File.Decrypt(FileName);
        }

        private void Encription_Click(object sender, EventArgs e)
        {
            CheckEncryption();
        }

        private void CheckEncryption()
        {
            if (!string.IsNullOrWhiteSpace(choosenFolder.Text))
            {
                FileAttributes attributes = File.GetAttributes(selected);
                if ((attributes & FileAttributes.Encrypted) == FileAttributes.Encrypted)
                {
                    encription.Text = "Decrypt";
                    RemoveEncryption(selected);
                }
                else
                {
                    encription.Text = "Encrypt";
                    AddEncryption(selected);
                }
            }
        }

        private void BrowseCopyFile_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileBrowser.ShowDialog();
            if (result == DialogResult.OK)
            {
                selectedCopy = openFileBrowser.FileName;
                textBox2.Text = selectedCopy;
            }
        }

        private void DestenationFolder_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowser.ShowDialog();
            if (result == DialogResult.OK)
            {
                selectedFolder = folderBrowser.SelectedPath;
                textBox3.Text = selectedFolder;
            }
        }

        private void CopyFile_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(textBox2.Text) && !string.IsNullOrWhiteSpace(textBox3.Text))
            {
                FileInfo fileSelected = new FileInfo(selectedCopy);
                File.Copy(selectedCopy, selectedFolder + "\\" + fileSelected.Name);
                copied.Text = "Succesfully copied file.";
            }
            else
            {
                copied.Text = "No selected file or directory";
            }

        }

        private void MoveFile_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox2.Text) && !string.IsNullOrWhiteSpace(textBox3.Text))
            {
                FileInfo fileSelected = new FileInfo(selectedCopy);
                File.Move(selectedCopy, selectedFolder + "\\" + fileSelected.Name);
                copied.Text = "Succesfully moved file.";
            }
            else
            {
                copied.Text = "No selected file or directory";
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowser.ShowDialog();
            if (result == DialogResult.OK)
            {
                selectedFolder = folderBrowser.SelectedPath;
                choosenFolder.Text = selectedFolder;
            }
        }

        private void CalculateSize_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(choosenFolder.Text))
            {
                DirectoryInfo info = new DirectoryInfo(selectedFolder);
                long totalSize = info.EnumerateFiles().Sum(file => file.Length);
                sizeOfChoosenDirectory.Text = totalSize.ToString() + "bytes";
            }
        }

        private void ChangeAttributes_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                FileAtrributesForm fileAtrributesForm = new FileAtrributesForm(textBox1.Text, fileSelected);
                fileAtrributesForm.Show();
            }
        }

        private void Search_Click(object sender, EventArgs e)
        {
            string[] files = Directory.GetFiles(searchDir.Text, regEx.Text, SearchOption.AllDirectories);
            ListSearchedFiles search = new ListSearchedFiles(files);
            search.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowser.ShowDialog();
            if (result == DialogResult.OK)
            {
                selectedFolder = folderBrowser.SelectedPath;
                searchDir.Text = selectedFolder;
            }
        }
    }
}