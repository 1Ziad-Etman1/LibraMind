using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LibraMind
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        public string conString = "Data Source=KINGAL;Initial Catalog=LIBRARY;Integrated Security=True";
        private void ExitX_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (EmailInput.TextLength == 0 || PasswordInput.TextLength == 0)
            {
                if (EmailInput.TextLength == 0)
                {
                    EmailErrorLabel.Text = "Required!";
                }
                else
                {
                    EmailErrorLabel.Text = "";
                }
                if (PasswordInput.TextLength == 0 || (PasswordInput.TextLength > 0 && PasswordInput.TextLength < 8))
                {
                    PasswordErrorLabel.Text = "Required!";
                }
                else
                {
                    PasswordErrorLabel.Text = "";
                }
            }
            else
            {
                string Uname = EmailInput.Text;
                string Pass = PasswordInput.Text;
                


                this.Hide(); // Hide the current form
                //SecondPageForm secPage = new SecondPageForm();
                //secPage.ShowDialog(); // Show the other form as a modal dialog
                this.Close(); // Close the current form
            }
        }
    }
}
