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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace txtEdit
{
    public partial class Form1 : Form
    {
        private string filePath = "";
        public Form1()
        {
        InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (*.txt)|*.txt";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;
                Text = Path.GetFileName(filePath) + " - Text Editor";
                richTextBox1.LoadFile(filePath);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text != "" && filePath != "")
            {
                DialogResult result = MessageBox.Show("Do you want to save changes?", "Save changes", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    richTextBox1(sender, e);
                }
                else if (result == DialogResult.Cancel)
                {
                    return;
                }
            }
            richTextBox1.Clear();
            filePath = "";
            Text = "Untitled - Text Editor";
        }
        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = string.Empty;
        }


        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            {
                if (richTextBox1.Text != "" && filePath != "")
                {
                    DialogResult result = MessageBox.Show("Do you want to save changes?", "Save changes", MessageBoxButtons.YesNoCancel);
                    if (result == DialogResult.Yes)
                    {
                        richTextBox1(sender, e);
                    }
                    else if (result == DialogResult.Cancel)
                    {
                        return;
                    }
                }
                richTextBox1.Clear();
                filePath = "";
                Text = "Untitled - Text Editor";
            }
        }
    }

}
