using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SanityArchiver
{
    public partial class ListSearchedFiles : Form
    {
        string[] fileNames;
        public ListSearchedFiles(string[] fileNames)
        {
            InitializeComponent();
            this.fileNames = fileNames;
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ListSearchedFiles_Load(object sender, EventArgs e)
        {
            foreach (String s in fileNames)
            {
                listSearched.Items.Add(s);
            }
        }
    }
}
