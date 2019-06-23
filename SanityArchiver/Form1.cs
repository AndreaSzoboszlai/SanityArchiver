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
            }
        }

        private void OpenSelected_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(selected);
        }

        private void Compressing_Click(object sender, EventArgs e)
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

        private void Compress()
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

        private void DeCompress()
        {
            FileInfo fileSelectedTo = new FileInfo(selected.Remove(selected.Length - fileSelected.Extension.Length));
            FileInfo fileSelectedFrom = new FileInfo(selected);
            FileStream input = fileSelectedFrom.OpenRead();
            FileStream output = File.Create(Path.GetDirectoryName(selected) +"\\" +  @"" + fileSelectedTo.Name);
            GZipStream deCompressor = new GZipStream(input, CompressionMode.Decompress);

            deCompressor.CopyTo(output);

            deCompressor.Close();
            input.Close();
            output.Close();
        }
    }
}
