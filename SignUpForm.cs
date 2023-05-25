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
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }
        public string conString = "Data Source=KINGAL;Initial Catalog=LIBRARY;Integrated Security=True";
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ExitX_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            if(UsernameInput.TextLength == 0 || PasswordInput.TextLength == 0 || ConfirmPasswordInput.TextLength == 0 || EmailInput.TextLength == 0 || PasswordInput.TextLength < 8 || PasswordInput.Text != ConfirmPasswordInput.Text )
            {

                if(UsernameInput.TextLength == 0)
                {
                    UsernameErrorLabel.Text = "Required!";
                }
                else
                {
                    UsernameErrorLabel.Text = "";
                }


                if (EmailInput.TextLength == 0)
                {
                    EmailErrorLabel.Text = "Required!";
                }
                else
                {
                    EmailErrorLabel.Text = "";
                }


                if(PasswordInput.TextLength == 0 || (PasswordInput.TextLength > 0 && PasswordInput.TextLength < 8))
                {
                    PasswordErrorLabel.Text = "At least 8 chars!";
                }
                else
                {
                    PasswordErrorLabel.Text = "";
                }


                if (ConfirmPasswordInput.TextLength == 0)
                {
                    ConfirmPasswordErrorLabel.Text = "Required!";
                }
                else if(ConfirmPasswordInput.TextLength > 0 && ConfirmPasswordInput.Text != PasswordInput.Text)
                {
                    ConfirmPasswordErrorLabel.Text = "No Match!";
                }
                else
                {
                    ConfirmPasswordErrorLabel.Text = "";
                }

            }
            else
            {
                string Uname = UsernameInput.Text;
                string CPass = ConfirmPasswordInput.Text;
                string Pass  = PasswordInput.Text;
                string Email = EmailInput.Text;

                SqlConnection con = new SqlConnection(conString);
                con.Open();
                if (con.State == System.Data.ConnectionState.Open)
                {
                    string sqlCommand = "INSERT INTO [USER] (USER_ID, F_NAME, L_NAME, TOTAL_FINE, EMAIL, PASSWORD, NATIONALITY, POSITION)" +
                        " VALUES (77, @Param1, 'FCAI', 0.0, @Param2, @Param3, 'Egyption', 'Student')";
                    SqlCommand command = new SqlCommand(sqlCommand, con);
                    command.Parameters.AddWithValue("@param1", Uname);
                    //command.Parameters.AddWithValue("@param2", " ");
                    //command.Parameters.AddWithValue("@param3", 0.0);
                    command.Parameters.AddWithValue("@param2", Email);
                    command.Parameters.AddWithValue("@param3", Pass);
                    //command.Parameters.AddWithValue("@param5", "Egyption");
                    //command.Parameters.AddWithValue("@param6", "Student");

                    command.ExecuteNonQuery();

                    con.Close();

                    this.Hide(); // Hide the current form
                    SecondPageForm secPage = new SecondPageForm();
                    secPage.ShowDialog(); // Show the other form as a modal dialog
                    this.Close(); // Close the current form
                }
                else
                {
                    UsernameErrorLabel.Text = "SERVER CONNECTION ERROR!";
                }
            }
        }

        private void CheckAgreeLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
