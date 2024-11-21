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
    public partial class Help_View : Form
    {
        public Help_View()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Help HelpApp = new Help();
            HelpApp.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
