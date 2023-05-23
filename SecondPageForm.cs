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
    public partial class SecondPageForm : Form
    {
        public SecondPageForm()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide the current form
            LoginForm LogPage = new LoginForm();
            LogPage.ShowDialog(); // Show the other form as a modal dialog
            this.Close(); // Close the current form
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide the current form
            SignUpForm SignUpPage = new SignUpForm();
            SignUpPage.ShowDialog(); // Show the other form as a modal dialog
            this.Close(); // Close the current form
        }
    }
}
