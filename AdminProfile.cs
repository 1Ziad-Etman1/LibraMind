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
    public partial class AdminProfile : Form
    {
        public AdminProfile()
        {
            InitializeComponent();
        }

        private void LogoutLabelBtn_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide the current form
            FirstPageForm FPage = new FirstPageForm();
            FPage.ShowDialog(); // Show the other form as a modal dialog
            this.Close(); // Close the current form
        }
        public string conString = "Data Source=KINGAL;Initial Catalog=LIBRARY;Integrated Security=True";

        private void OkBtn_Click(object sender, EventArgs e)
        {
            if (IdInput.TextLength != 0)
            {
                string id = IdInput.Text;


                SqlConnection con = new SqlConnection(conString);
                con.Open();
                if (con.State == System.Data.ConnectionState.Open)
                {
                    string query = "SELECT F_NAME, EMAIL, PASSWORD, NATIONALITY, POSITION FROM [USER] WHERE ID=@Param1";
                    SqlCommand command = new SqlCommand(query, con);
                    command.Parameters.AddWithValue("@Param1", id);
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    string Uname = reader.GetString(0);
                    string EmailValue = reader.GetString(1);
                    string PassValue = reader.GetString(2);
                    string nationality = reader.GetString(3);
                    string position = reader.GetString(4);
                    reader.Close();
                    con.Close();
                    IdLabel.Visible = false;
                    IdInput.Visible = false;
                    OkBtn.Visible = false;
                    UsernameLabel.Visible = true;
                    UsernameLabel.Text = Uname;
                    Email.Visible = true;
                    EmailLabel.Visible = true;
                    EmailLabel.Text = EmailValue;
                    Password.Visible = true;
                    PasswordLabel.Visible = true;
                    PasswordLabel.Text = PassValue;
                    Position.Visible = true;
                    PositionLabel.Visible = true;
                    PositionLabel.Text = position;
                    Nationallity.Visible = true;
                    NationalityLabel.Visible = true;
                    NationalityLabel.Text = nationality;
                    ErrorLabel.Visible = false;
                }
            }
            else
            {
                ErrorLabel.Visible = true;
            }
        }
    }
}
