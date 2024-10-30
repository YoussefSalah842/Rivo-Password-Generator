using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rivo_Password_Generator
{
    public partial class Password_Manager : Form
    {
        public Password_Manager()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            MessageBox.Show("All generated passwords have been deleted.", "Cleared", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            float fontSize = Math.Min((float)numericUpDown1.Value, 34);


            richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, fontSize);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text Files (*.txt)|*.txt|Rich Text Format (*.rtf)|*.rtf";
            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.AddExtension = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Save the content based on the selected file extension
                if (saveFileDialog1.FilterIndex == 1) // If Text File
                {
                    System.IO.File.WriteAllText(saveFileDialog1.FileName, richTextBox1.Text);
                }
                else // If Rich Text Format
                {
                    richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.RichText);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Through this tool you can view all the passwords you have written here and you can also copy some of them or save them all by clicking on the Save button below.", "Help Program",MessageBoxButtons.OK,MessageBoxIcon.Question); 
        }
    }
}
