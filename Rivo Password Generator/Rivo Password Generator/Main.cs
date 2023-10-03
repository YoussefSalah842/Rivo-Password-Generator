using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Rivo_Password_Generator.Properties;

namespace Rivo_Password_Generator
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        const string LOWER_CASE = "abcdefghijklmnopqursuvwxyz";
        const string UPPER_CASE = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        const string NUMBERIC = "1234567890";
        const string SPECIAL_CHARACTER = @"~!@#$%^&*()+=-";


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public string PasswordGenerator(bool lowerCase, bool upperCase, bool mumberic, bool specialCharacter, int length)
        {
            char[] password = new char[length];
            string charSet = "";
            System.Random _random = new Random();
            if (lowerCase)
                charSet += LOWER_CASE;
            if (upperCase)
                charSet += UPPER_CASE;
            if (mumberic)
                charSet += NUMBERIC;
            if (specialCharacter)
                charSet += SPECIAL_CHARACTER;
            for (int i = 0; i < length; i++)
                password[i] = charSet[_random.Next(charSet.Length - 1)];
            return string.Join(null, password);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                txtPassword.Text = PasswordGenerator(chkLowerCase.Checked, chkUpperCase.Checked, chkNumeric.Checked, chkSpecical.Checked, int.Parse(txtPasswordLength.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtPassword.Copy();

            MessageBox.Show("Copy completed successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://youssefpro986.blogspot.com/p/privacy-policy.html");
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://youssefpro986.blogspot.com/p/usage-agreement.html");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = 
            saveFileDialog1.Title = "Save text Files";
            saveFileDialog1.CheckFileExists = true;
            saveFileDialog1.CheckPathExists = true;
            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtPassword.Text = saveFileDialog1.FileName;
            }
    }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Rivo Password Generator V1.6 developed by Youssef Salah", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txtPassword.PasswordChar = '*';
            }

            if (checkBox1.Checked == false)
            {
                    txtPassword.PasswordChar = '\0';
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
