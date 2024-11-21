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
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Help_View HelpViewApp = new Help_View();
            HelpViewApp.Show();
            HelpViewApp.HelpTitle.Text = "Introduction to the application and how to use it";
            HelpViewApp.HelpDesr1.Text = "Welcome to Rivo Password Generator, a powerful and user-friendly tool designed to help you create secure passwords effortlessly. In today’s digital age, where online security is paramount, having strong, unique passwords for each of your accounts is crucial. Rivo Password Generator addresses this need by providing an easy-to-use interface that generates robust passwords tailored to your specifications.";
            HelpViewApp.HelpDesr2.Text = "you can easily create strong, unique passwords that protect your personal information.";
            HelpViewApp.IMGTEXT.Text = "Screenshot of the main interface of the program";
            HelpViewApp.pictureBox2.Image = Properties.Resources.main_interface;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Help_View HelpViewApp = new Help_View();
            HelpViewApp.Show();
            HelpViewApp.HelpTitle.Text = "How do I create a very strong password?";
            HelpViewApp.HelpDesr1.Text = "Use at least 12 - 15 or More characters, mixing uppercase and lowercase letters, numbers, and symbols. Avoid common words or sequences like 12345 and make each password unique for every account. A passphrase with random words (e.g PurpleGiraffe!Skates) is also effective and memorable";
            HelpViewApp.HelpDesr2.Text = "Enable two-factor authentication (2FA) for extra protection, and update passwords regularly.";
            HelpViewApp.IMGTEXT.Text = "Screenshot of the Additional Password Options";
            HelpViewApp.pictureBox2.Image = Properties.Resources.Additional_Options;
            HelpViewApp.pictureBox2.BorderStyle = BorderStyle.Fixed3D;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Help_View HelpViewApp = new Help_View();
            HelpViewApp.Show();
            HelpViewApp.HelpTitle.Text = "How do I use a password manager?";
            HelpViewApp.HelpDesr1.Text = "Use at least 12 - 15 or More characters, mixing uppercase and lowercase letters, numbers, and symbols. Avoid common words or sequences like 12345 and make each password unique for every account. A passphrase with random words (e.g PurpleGiraffe!Skates) is also effective and memorable";
            HelpViewApp.HelpDesr2.Text = "Enable two-factor authentication (2FA) for extra protection, and update passwords regularly.";
            HelpViewApp.IMGTEXT.Text = "Screenshot of the New Password Manager";
            HelpViewApp.pictureBox2.Image = Properties.Resources.Password_Manager__new;
        }
    }
}
