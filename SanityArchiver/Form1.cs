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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Browse_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileBrowser.ShowDialog();
            if (result == DialogResult.OK)
            {
                string selected = openFileBrowser.FileName;
                textBox1.Text = selected;
                System.Diagnostics.Process.Start(selected);
            }
            Console.WriteLine(result);
        }
    }
}
