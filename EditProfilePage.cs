using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        }

        private void StatisticsLabelBtn_Click(object sender, EventArgs e)
        {

        }

        private void DashBoardIcon_Click(object sender, EventArgs e)
        {

        }

        private void RightPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void EditUserLabelBtn_Click(object sender, EventArgs e)
        {

        }

        private void ManageBookLabelBtn_Click(object sender, EventArgs e)
        {

        }

        private void ProfileLabelBtn_Click(object sender, EventArgs e)
        {

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

        private void UpdateBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
