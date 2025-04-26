namespace Dybss
{
    public partial class Form1 : Form
    {
        bool show = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignInForm signIn = new SignInForm();
            signIn.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Text = !show ? "😪" : "👀";
            textBox4.UseSystemPasswordChar = show;
            show = !show;
        }
    }
}
