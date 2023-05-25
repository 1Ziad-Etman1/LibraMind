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
    public partial class ViewRequests : Form
    {
        public ViewRequests()
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

        private void LogoutLabelBtn_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide the current form
            FirstPageForm FPage = new FirstPageForm();
            FPage.ShowDialog(); // Show the other form as a modal dialog
            this.Close(); // Close the current form
        }

        private void ManageBookLabelBtn_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide the current form
            ManageBookPage mp = new ManageBookPage();
            mp.ShowDialog(); // Show the other form as a modal dialog
            this.Close(); // Close the current form
        }

        private void EditUserLabelBtn_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide the current form
            EditUserPage eu = new EditUserPage();
            eu.ShowDialog(); // Show the other form as a modal dialog
            this.Close(); // Close the current form
        }

        private void EditProfileLabelBtn_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide the current form
            EditProfilePage eu = new EditProfilePage();
            eu.ShowDialog(); // Show the other form as a modal dialog
            this.Close(); // Close the current form
        }

        private void StatisticsLabelBtn_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide the current form
            Statistics s = new Statistics();
            s.ShowDialog(); // Show the other form as a modal dialog
            this.Close(); // Close the current form
        }
    }
}
