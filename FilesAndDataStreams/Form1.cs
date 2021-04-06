using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilesAndDataStreams
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ДанныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = File.ReadAllText("D:\\templog.txt");
        }

        private void RenameStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = "rename";
        }

        private void DeleteStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Delete";
        }

        private void ReadDataStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Read";
        }

        private void LoggingStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Logging";
        }

        private void AuthorStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Author";
        }

        private void CopyStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Copy";
        }

        private void ArchiveStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Archive";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
