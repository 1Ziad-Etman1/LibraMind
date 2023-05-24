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
    public partial class Page1 : Form
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void SigninButton_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide the current form
            Page2 secPage = new Page2();
            secPage.ShowDialog(); // Show the other form as a modal dialog
            this.Close(); // Close the current form
        }

        private void UsernameInput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
