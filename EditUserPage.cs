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
    }
}
