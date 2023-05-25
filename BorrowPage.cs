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
            AvailableLable.Text = "";
            Available.Visible = false;
            ISBN.Visible = false;
            ISBNLabel.Text = "";
            if (BookNameInput.TextLength != 0 && IdInput.TextLength != 0)
            {
                Available.Visible = true;
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
                        bool Avaliablee = reader.GetBoolean(1);
                        reader.Close();
                        con.Close();
                        if(Avaliablee == true)
                        {
                            AvailableLable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
                            Available.Visible = true;
                            AvailableLable.Visible = true;
                            AvailableLable.Text = "Yes";
                            ISBN.Visible = true;
                            ISBNLabel.Text = Convert.ToString(isbn);
                            con.Open();
                            string query2 = "INSERT INTO BORROWING (BORROW_ID, U__ID, ISBN__B) VALUES (66, @Param2, @Param3)";
                            SqlCommand command2 = new SqlCommand(query2, con);
                            command2.Parameters.AddWithValue("@Param2", IdInput.Text);
                            command2.Parameters.AddWithValue("@Param3", isbn);
                            command2.ExecuteNonQuery();
                            con.Close();

                            con.Open();
                            string query3 = "INSERT INTO BORROW (USER_ID, BORROW_ID, BORROW_DATE, RETURN_DATE) VALUES (@Param4, 66, '2023-05-25 18:00:00.000', '2023-05-25 18:00:00.000')";
                            SqlCommand command3 = new SqlCommand(query3, con);
                            command3.Parameters.AddWithValue("@Param4", IdInput.Text);
                            command3.ExecuteNonQuery();


                            con.Close();
                        }
                        else
                        {

                            Available.Visible = true;
                            AvailableLable.Visible = true;
                            AvailableLable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
                            AvailableLable.Text = "No";
                        }
                    }
                    else
                    {
                        Available.Visible = true;
                        AvailableLable.Visible = true;
                        AvailableLable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
                        AvailableLable.Text = "No";
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
