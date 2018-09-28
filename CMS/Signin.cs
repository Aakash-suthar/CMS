using MetroFramework.Forms;
using System.Windows.Forms;
using System.Drawing;
using System;

namespace CMS
{
    public partial class Signin : MetroForm
    {
        public Signin()
        {
            InitializeComponent();
        }

        private void ShowPassLabel_MouseDown(object sender, MouseEventArgs e)
        {
            PassTextBox.PasswordChar = '\0';
            ConfirmPassTextBox.PasswordChar = '\0';
        }

        private void BackButton_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }

        private void ResetButton_Click(object sender, System.EventArgs e)
        {
            PassTextBox.Clear();FirstTextBox.Clear();LastTextBox.Clear();
            ConfirmPassTextBox.Clear();GmailTextBox.Clear();UserTextBox.Clear();
        }

        private void RegisterButton_Click(object sender, System.EventArgs e)
        {
            if (FirstTextBox.Text == "") FirstTextBox.PromptText = "Field Cant be Blank";
            if (LastTextBox.Text == "") LastTextBox.PromptText = "Field Cant be Blank";
            if (UserTextBox.Text == "") FirstTextBox.PromptText = "Field Cant be Blank";
            if (PassTextBox.Text == "") PassTextBox.PromptText = "Field Cant be Blank";
            if(UserTextBox.Text=="" ) UserTextBox.PromptText = "Field Cant be Blank";
            if (ConfirmPassTextBox.Text == "") { ConfirmPassTextBox.PromptText = "Field Cant be Blank"; }

            if(FirstLabel.ForeColor.Equals(Color.Green) && 
                LastLabel.ForeColor.Equals(Color.Green) && 
                UserLabel.ForeColor.Equals(Color.Green) &&
                PasswordLabel.ForeColor.Equals(Color.Green) &&
                ConfirmPassLabel.ForeColor.Equals(Color.Green) &&
                GmailLabel.ForeColor.Equals(Color.Green)) {

                try
                {
                    if (Info.Save(UserTextBox.Text, PassTextBox.Text, GmailTextBox.Text, FirstTextBox.Text, LastTextBox.Text))
                    {
                        this.Close();
                        MessageBox.Show("SuccessFully Register....");
                        Form1 f = new Form1();
                        f.Show();
                    }
                    else MessageBox.Show("Error Registering. Try again Later","Alert",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                catch (Exception r)
                {
                    
                    MessageBox.Show(r.Message);
                }

            }
        }

        private void ShowPassLabel_MouseUp(object sender, MouseEventArgs e)
        {
            PassTextBox.PasswordChar = '*';
            ConfirmPassTextBox.PasswordChar = '*';
        }

        private void FirstTextBox_TextChanged(object sender, System.EventArgs e)
        {
            if (FirstTextBox.Text.Length >= 5) { FirstLabel.ForeColor =Color.Green; } else { FirstLabel.ForeColor = Color.Crimson; }
            if (LastTextBox.Text.Length >= 5) { LastLabel.ForeColor = Color.Green; } else { LastLabel.ForeColor = Color.Crimson; }
            if (UserTextBox.Text.Length >= 8) { UserLabel.ForeColor = Color.Green; } else { UserLabel.ForeColor = Color.Crimson; }
            if (PassTextBox.Text.Length >= 8) { PasswordLabel.ForeColor = Color.Green; } else { PasswordLabel.ForeColor = Color.Crimson; }
            if (ConfirmPassTextBox.Text==PassTextBox.Text && PasswordLabel.ForeColor!=Color.Crimson) { ConfirmPassLabel.ForeColor = Color.Green; } else { ConfirmPassLabel.ForeColor = Color.Crimson; }
        }

        private void GmailTextBox_TextChanged(object sender, System.EventArgs e)
        {
            if (Validation.CheckGmail(GmailTextBox.Text)) { GmailLabel.ForeColor = Color.Green; }
            else GmailLabel.ForeColor = Color.Crimson;
        }
    }
}
