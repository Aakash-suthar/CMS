using MetroFramework.Forms;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CMS
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
            if (!Info.CheckDatabase())
            {
                Info.GenerateDatabase();
            }
        }


        private void metroLink1_Click(object sender, System.EventArgs e)
        {
            Hide();
            Signin s = new Signin();
            s.Show();
        }

        private void metroLink3_MouseDown(object sender, MouseEventArgs e)
        {
            
            PassTextBox.PasswordChar = '\0';
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void metroLink3_MouseUp(object sender, MouseEventArgs e)
        {
            PassTextBox.PasswordChar = '*';
        }

        private void metroButton1_Click(object sender, System.EventArgs e)
        {
            if (UserTextBox.Text.Length > 4 && PassTextBox.Text.Length >= 8)
            {

                if (Info.Read(UserTextBox.Text, PassTextBox.Text))
                {
                    this.Hide();
                    StockMain d = new StockMain();
                    d.Show();
                }
                else
                {
                    MessageBox.Show(this, "Wrong Username Or Password", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    UserTextBox.Text = "";
                    PassTextBox.Text = "";
                }
            }
            else
            {
                MessageBox.Show(this, "Wrong Username Or Password", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                UserTextBox.Text = "";
                PassTextBox.Text = "";
            }
        }
    }
}
