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
    public partial class ReturnPage : Form
    {
        public ReturnPage()
        {
            InitializeComponent();
        }

        private void ProfileLabelBtn_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide the current form
            Profile ProfPage = new Profile();
            ProfPage.ShowDialog(); // Show the other form as a modal dialog
            this.Close(); // Close the current form
        }

        private void LogoutLabelBtn_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide the current form
            FirstPageForm FPage = new FirstPageForm();
            FPage.ShowDialog(); // Show the other form as a modal dialog
            this.Close(); // Close the current form
        }
        public string conString = "Data Source=KINGAL;Initial Catalog=LIBRARY;Integrated Security=True";

        private void ReturnBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {

                string query = "SELECT AVALIABLE FROM [BOOK] WHERE ISBN = @Param1";
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@Param1", ISBNInput.Text);
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                bool Avaliable = reader.GetBoolean(0);
                reader.Close();
                con.Close();
                if (Avaliable == false)
                {
                    Error.Visible = true;
                }
                else
                {
                    Fine.Visible = true;
                    FineLabel.Visible = true;
                    FineLabel.Text = "0.0";

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

        private void ReturnLabelBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
