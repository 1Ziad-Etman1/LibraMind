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
    public partial class EditUserPage : Form
    {
        public EditUserPage()
        {
            InitializeComponent();
        }

        private void ProfileLabelBtn_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide the current form
            AdminProfile Ap = new AdminProfile();
            Ap.ShowDialog(); // Show the other form as a modal dialog
            this.Close(); // Close the current form
        }

        private void ManageBookLabelBtn_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide the current form
            ManageBookPage mp = new ManageBookPage();
            mp.ShowDialog(); // Show the other form as a modal dialog
            this.Close(); // Close the current form
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            if (IdInput.TextLength != 0)
            {
                string id = IdInput.Text;

                IdLabel.Visible = false;
                IdInput.Visible = false;
                OkBtn.Visible = false;
                UpdatePanel.Visible = true;
            }
        }

        private void EditProfileLabelBtn_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide the current form
            EditProfilePage EPPage = new EditProfilePage();
            EPPage.ShowDialog(); // Show the other form as a modal dialog
            this.Close(); // Close the current form
        }

        private void ViewRequistLabelBtn_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide the current form
            ViewRequests VRPage = new ViewRequests();
            VRPage.ShowDialog(); // Show the other form as a modal dialog
            this.Close(); // Close the current form
        }

        private void LogoutLabelBtn_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide the current form
            ReturnPage FPage = new ReturnPage();
            FPage.ShowDialog(); // Show the other form as a modal dialog
            this.Close(); // Close the current form
        }

        private void EditUserLabelBtn_Click(object sender, EventArgs e)
        {

        }
        public string conString = "Data Source=KINGAL;Initial Catalog=LIBRARY;Integrated Security=True";

        private void UpdateBtn_Click(object sender, EventArgs e)
        {

            string id = IdInput.Text;

            if (EmailInput.TextLength > 0 && PasswordInput.TextLength > 0)
            {
                string Pass = PasswordInput.Text;
                string Email = EmailInput.Text;
                string position = PositionInput.Text;

                SqlConnection con = new SqlConnection(conString);
                con.Open();
                if (con.State == System.Data.ConnectionState.Open)
                {
                    string sqlCommand = "UPDATE [USER] SET EMAIL=@Param1, PASSWORD=@Param2, POSITION=@Param3 WHERE USER_ID=@Param4";
                    SqlCommand command = new SqlCommand(sqlCommand, con);

                    command.Parameters.AddWithValue("@param1", Email);
                    command.Parameters.AddWithValue("@param2", Pass);
                    command.Parameters.AddWithValue("@param3", position);
                    command.Parameters.AddWithValue("@param4", id);

                    command.ExecuteNonQuery();

                    con.Close();
                    EmailInput.Text = "";
                    PasswordInput.Text = "";
                    PositionInput.Text = "";
                }
            }
        }

        private void PositionInput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
