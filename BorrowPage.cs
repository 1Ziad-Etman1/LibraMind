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
    public partial class BorrowPage : Form
    {
        public BorrowPage()
        {
            InitializeComponent();
        }

        private void ProfileLabelBtn_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide the current form
            Profile ProfPage = new Profile();
            ProfPage.ShowDialog(); // Show the other form as a modal dialog
            this.Close(); // Close the current forms
        }

        private void LogoutLabelBtn_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide the current form
            FirstPageForm FPage = new FirstPageForm();
            FPage.ShowDialog(); // Show the other form as a modal dialog
            this.Close(); // Close the current form
        }
        private void ReturnLabelBtn_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide the current form
            ReturnPage FPage = new ReturnPage();
            FPage.ShowDialog(); // Show the other form as a modal dialog
            this.Close(); // Close the current form
        }
        public string conString = "Data Source=KINGAL;Initial Catalog=LIBRARY;Integrated Security=True";

        private void BorrowBtn_Click(object sender, EventArgs e)
        {
            if (BookNameInput.TextLength != 0 && IdInput.TextLength != 0)
            {
                SqlConnection con = new SqlConnection(conString);
                con.Open();
                if (con.State == System.Data.ConnectionState.Open)
                {
                    string bname = BookNameInput.Text;
                    string query = "SELECT ISBN, AVALIABLE FROM [BOOK] WHERE TITLE=@Param1";
                    SqlCommand command = new SqlCommand(query, con);
                    command.Parameters.AddWithValue("@Param1", bname);
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        string isbn = reader.GetString(0);
                        bool Avaliable = reader.GetBoolean(1);
                        reader.Close();
                        con.Close();
                        if(Avaliable == true)
                        {
                            Available.Visible = true;
                            AvailableLable.Text = "Yes";
                            ISBN.Visible = true;
                            ISBNLabel.Text = Convert.ToString(isbn);
                        }
                        else
                        {
                            Available.Visible = true;
                            AvailableLable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
                            AvailableLable.Text = "No";
                        }
                    }
                    else
                    {

                    }
                }
            }
        }

        private void BorrowLabelBtn_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide the current form
            BorrowPage BPage = new BorrowPage();
            BPage.ShowDialog(); // Show the other form as a modal dialog
            this.Close(); // Close the current form
        }

        private void RightPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
