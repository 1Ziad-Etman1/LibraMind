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
    public partial class ManageBookPage : Form
    {
        public ManageBookPage()
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

        private void ProfileLabelBtn_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide the current form
            AdminProfile Ap = new AdminProfile();
            Ap.ShowDialog(); // Show the other form as a modal dialog
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

        private void ViewRequistLabelBtn_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide the current form
            ViewRequests vr = new ViewRequests();
            vr.ShowDialog(); // Show the other form as a modal dialog
            this.Close(); // Close the current form
        }

        private void AddBookLabelBtn_Click(object sender, EventArgs e)
        {
            AddBookPanel.Visible = true;
            DropBookPanel.Visible = false;
        }

        private void DropBookLabelBtn_Click(object sender, EventArgs e)
        {
            DropBookPanel.Visible = true;
            AddBookPanel.Visible = false;
        }
        public string conString = "Data Source=KINGAL;Initial Catalog=LIBRARY;Integrated Security=True";

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (BookNameInput.TextLength > 0 && ISBNInput.TextLength > 0 && NumOfCopiesInput.TextLength > 0)
            {
                string title = BookNameInput.Text;
                string isbn = ISBNInput.Text;
                string NCopies = NumOfCopiesInput.Text;
                SqlConnection con = new SqlConnection(conString);
                con.Open();
                if (con.State == System.Data.ConnectionState.Open)
                {
                    string sqlCommand = "INSERT INTO [BOOK] (TITLE, ISBN, COPIES, PUBLICATION_YEAR, AUTHER_ID, P_ID, PRICE, EDITION, AVALIABLE, NO_PAGES)" +
                        " VALUES (@Param1, @Param2, @Param3, 2010, 22, 11, 5.5, 1, 1, 300)";
                    SqlCommand command = new SqlCommand(sqlCommand, con);
                    command.Parameters.AddWithValue("@param1", title);
                    command.Parameters.AddWithValue("@param2", isbn);
                    command.Parameters.AddWithValue("@param3", NCopies);
                    
                    command.ExecuteNonQuery();

                    con.Close();

                    BookNameInput.Text = "";
                    ISBNInput.Text = "";
                    NumOfCopiesInput.Text = "";
                    AddBookPanel.Visible = false;
                }
            }
        }

        private void DropBtn_Click(object sender, EventArgs e)
        {
            if (ISBNInputDrop.TextLength > 0)
            {
                string isbn = ISBNInputDrop.Text;
                SqlConnection con = new SqlConnection(conString);
                con.Open();
                if (con.State == System.Data.ConnectionState.Open)
                {
                    string sqlCommand = "DELETE FROM BOOK WHERE ISBN = @param1";
                    SqlCommand command = new SqlCommand(sqlCommand, con);
                    command.Parameters.AddWithValue("@param1", isbn);

                    command.ExecuteNonQuery();

                    con.Close();

                    
                    ISBNInputDrop.Text = "";
                    DropBookPanel.Visible = false;
                }
            }
        }
    }
}
