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
using System.Drawing.Printing;

namespace NotePad
{
    public partial class Form1 : Form
    {
        private string _openFile;
        public Form1()
        {
            InitializeComponent();
        }

        private void шрифтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog myFont = new FontDialog();
            if (myFont.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Font = myFont.Font;
            }
        }

        private void новоеОкноToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog importFile = new OpenFileDialog();
            importFile.Filter = "all (*_*) | *.*";
            if (importFile.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Text = File.ReadAllText(importFile.FileName);
                _openFile = importFile.FileName;
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Хотите выйти?", "Выход", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog openFile = new SaveFileDialog();
            openFile.Filter = "Текстовый документ (*.txt) | *.*";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(openFile.FileName, richTextBox1.Text);
                _openFile = openFile.FileName;
            }
        }


        public void Print(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(richTextBox1.Text, richTextBox1.Font, Brushes.Black, 0, 0);
        }

        private void Print(object sender, EventArgs e)
        {
            PrintDocument pDocunment = new PrintDocument();
            pDocunment.PrintPage += Print;
            PrintDialog pDialog = new PrintDialog();
            pDialog.Document = pDocunment;
            if (pDialog.ShowDialog() == DialogResult.OK)
            {
                pDialog.Document.Print();
            }
        }
        private void ColorText(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            dialog.ShowDialog();
            richTextBox1.SelectionColor = dialog.Color;

        }

        private void SaveFile(object sender, EventArgs e)
        {
            SaveFileDialog openFile = new SaveFileDialog();
            openFile.Filter = "Текстовый документ (*.txt) | *.*";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(openFile.FileName, richTextBox1.Text);
                _openFile = openFile.FileName;
            }
        }

        private void Reference(object sender, EventArgs e)
        {
            MessageBox.Show("Текстовый редактор");
        }
        private void Copy(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void Paste(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void Cut(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }
    }
}




