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
        private Password_Manager passwordManagerForm; // تعريف متغير النموذج هنا

        public Main()
        {
            InitializeComponent();
            passwordManagerForm = new Password_Manager();
            passwordManagerForm.Hide();
        }

        const string LOWER_CASE = "abcdefghijklmnopqursuvwxyz";
        const string UPPER_CASE = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        const string NUMBERIC = "1234567890";
        const string SPECIAL_CHARACTER = @"~!@#$%^&*()+=-";

        private void Form1_Load(object sender, EventArgs e)
        {
            // لا حاجة لفتح النموذج هنا، لأنه سيتم استخدامه في الخلفية
        }

        public string PasswordGenerator(bool lowerCase, bool upperCase, bool mumberic, bool specialCharacter, int length)
        {
            char[] password = new char[length];
            string charSet = "";
            Random _random = new Random();
            if (lowerCase) charSet += LOWER_CASE;
            if (upperCase) charSet += UPPER_CASE;
            if (mumberic) charSet += NUMBERIC;
            if (specialCharacter) charSet += SPECIAL_CHARACTER;

            for (int i = 0; i < length; i++)
                password[i] = charSet[_random.Next(charSet.Length)];
            return string.Join(string.Empty, password);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string newPassword = PasswordGenerator(
                    chkLowerCase.Checked,
                    chkUpperCase.Checked,
                    chkNumeric.Checked,
                    chkSpecical.Checked,
                    int.Parse(txtPasswordLength.Text)
                );

                txtPassword.Text = newPassword;

                // إضافة كلمة المرور المولدة إلى richTextBox1 في Password_Manager
                passwordManagerForm.richTextBox1.Text = newPassword + Environment.NewLine + passwordManagerForm.richTextBox1.Text;

                // يمكنك فتح النموذج هنا إذا أردت، ولكن بما أنه مخفي، فليس ضروريًا
                // passwordManagerForm.Show();
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
            SaveFileDialog saveFileDialog1 = new SaveFileDialog
            {
                Title = "Save text Files",
                CheckFileExists = true,
                CheckPathExists = true,
                DefaultExt = "txt",
                Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*",
                FilterIndex = 2,
                RestoreDirectory = true
            };
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtPassword.Text = saveFileDialog1.FileName;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Rivo Password Generator V1.9 developed by Youssef Salah", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = checkBox1.Checked ? '*' : '\0';
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            passwordManagerForm.Show(); // إذا كنت ترغب في فتح النموذج من هنا
        }
    }
}