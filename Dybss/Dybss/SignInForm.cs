using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dybss
{
    public partial class SignInForm : Form
    {
        bool show = false;
        public SignInForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 signUp = new Form1();
            signUp.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {

            button3.Text = !show ? "😪" : "👀";
            textBox2.UseSystemPasswordChar = show;
            show = !show;

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
