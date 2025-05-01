using Bibliotheque.Classes;
using Bibliotheque.Controlleurs;
using MySql.Data.MySqlClient;

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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
            Utilisateurs newUser = new Utilisateurs(textBox1.Text , textBox2.Text , textBox3.Text , textBox4.Text);
            UtilisateursCtlr user = UtilisateursCtlr.Instance;
                if (user.Enregistrement(newUser))
                    MessageBox.Show("l'utilisateur est bien enregistre");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("erreur pendant enregistrement"+ex);
            }
            catch(Exception ex)
            {
                MessageBox.Show("erreur pendant enregistrement"+ex);

            }
          
        }
    }
}
