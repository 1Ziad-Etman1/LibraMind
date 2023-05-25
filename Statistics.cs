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
    public partial class Statistics : Form
    {
        public Statistics()
        {
            InitializeComponent();
        }
        public string conString = "Data Source=KINGAL;Initial Catalog=LIBRARY;Integrated Security=True";

        private void ShowStatBtn_Click(object sender, EventArgs e)
        {
            StatPanel.Visible = true;
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                string query = "SELECT COUNT(*) AS TotalBooks FROM BOOK ";
                SqlCommand command = new SqlCommand(query, con);
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                int Book = reader.GetInt32(0);
                Books.Text = Convert.ToString(Book);
                reader.Close();
                

                string query2 = "SELECT COUNT(*) AS TotalUsers FROM [USER] ";
                SqlCommand command2 = new SqlCommand(query2, con);
                SqlDataReader reader2 = command2.ExecuteReader();
                reader2.Read();
                int User = reader2.GetInt32(0);
                Users.Text = Convert.ToString(User);
                reader2.Close();

                string query3 = "SELECT COUNT(*) AS TotalFines FROM FINE ";
                SqlCommand command3 = new SqlCommand(query3, con);
                SqlDataReader reader3 = command3.ExecuteReader();
                reader3.Read();
                int Fine = reader3.GetInt32(0);
                Fines.Text = Convert.ToString(Fine);
                reader3.Close();

                string query4 = "SELECT COUNT(*) AS TotalBorrows FROM BORROW ";
                SqlCommand command4 = new SqlCommand(query4, con);
                SqlDataReader reader4 = command4.ExecuteReader();
                reader4.Read();
                int Borrow = reader4.GetInt32(0);
                Borrows.Text = Convert.ToString(Borrow);
                reader4.Close();
                con.Close();
            }
            }

        private void ProfileLabelBtn_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide the current form
            AdminProfile APPage = new AdminProfile();
            APPage.ShowDialog(); // Show the other form as a modal dialog
            this.Close(); // Close the current form
        }

        private void ManageBookLabelBtn_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide the current form
            ManageBookPage MBPage = new ManageBookPage();
            MBPage.ShowDialog(); // Show the other form as a modal dialog
            this.Close(); // Close the current form
        }

        private void EditUserLabelBtn_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide the current form
            EditUserPage EUPage = new EditUserPage();
            EUPage.ShowDialog(); // Show the other form as a modal dialog
            this.Close(); // Close the current form
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

        }

        private void LogoutLabelBtn_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide the current form
            FirstPageForm FPPage = new FirstPageForm();
            FPPage.ShowDialog(); // Show the other form as a modal dialog
            this.Close(); // Close the current form
        }
    }
}
