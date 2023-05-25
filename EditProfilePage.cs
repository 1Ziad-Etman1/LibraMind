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
    public partial class EditProfilePage : Form
    {
        public EditProfilePage()
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

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            string id = IdInput.Text;
            if (EmailInput.TextLength > 0 && PasswordInput.TextLength > 0)
            {
                string Pass = PasswordInput.Text;
                string Email = EmailInput.Text;

                SqlConnection con = new SqlConnection(conString);
                con.Open();
                if (con.State == System.Data.ConnectionState.Open)
                {
                    string sqlCommand = "UPDATE [USER] SET EMAIL = @Param1, PASSWORD = @Param2 WHERE USER_ID = @Param3";
                    SqlCommand command = new SqlCommand(sqlCommand, con);

                    command.Parameters.AddWithValue("@param1", Email);
                    command.Parameters.AddWithValue("@param2", Pass);
                    command.Parameters.AddWithValue("@param3", id);

                    command.ExecuteNonQuery();

                    con.Close();
                    EmailInput.Text = "";
                    PasswordInput.Text = "";

                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void DashBoardPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void EditProfileLabelBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void ViewRequistLabelBtn_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide the current form
            ViewRequests VRPage = new ViewRequests();
            VRPage.ShowDialog(); // Show the other form as a modal dialog
            this.Close(); // Close the current form
        }

        private void StatisticsLabelBtn_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide the current form
            Statistics s = new Statistics();
            s.ShowDialog(); // Show the other form as a modal dialog
            this.Close(); // Close the current form
        }

        private void DashBoardIcon_Click(object sender, EventArgs e)
        {

        }

        private void RightPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void EditUserLabelBtn_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide the current form
            EditUserPage eu = new EditUserPage();
            eu.ShowDialog(); // Show the other form as a modal dialog
            this.Close(); // Close the current form
        }

        private void ManageBookLabelBtn_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide the current form
            ManageBookPage mp = new ManageBookPage();
            mp.ShowDialog(); // Show the other form as a modal dialog
            this.Close(); // Close the current form
        }

        private void ProfileLabelBtn_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide the current form
            AdminProfile Ap = new AdminProfile();
            Ap.ShowDialog(); // Show the other form as a modal dialog
            this.Close(); // Close the current form
        }

        private void ProfessorLabel_Click(object sender, EventArgs e)
        {

        }

        private void DashBoardLabel_Click(object sender, EventArgs e)
        {

        }

        private void EditProfileLabel_Click(object sender, EventArgs e)
        {

        }

        private void UsernameLabel_Click(object sender, EventArgs e)
        {

        }

        private void PasswordInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void EmailInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
  

        private void OkBtn_Click(object sender, EventArgs e)
        {
            if (IdInput.TextLength != 0)
            {
                string id = IdInput.Text;
                    
                IdLabel.Visible = false;
                IdInput.Visible = false;
                OkBtn.Visible = false;
                EmailLabel.Visible = true;
                EmailInput.Visible = true;
                PasswordLabel.Visible = true;
                PasswordInput.Visible = true;
                UpdateBtn.Visible = true;
                }
            }
        }
    }

