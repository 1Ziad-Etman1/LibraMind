using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraMind
{
    
    static class Program
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FirstPageForm()); 
            //Application.Run(new SecondPageForm());
            //Application.Run(new SignUpForm());
            //Application.Run(new LoginForm());
            //Application.Run(new GreatHallStudent());
            //Application.Run(new Profile());
            //Application.Run(new BorrowPage());
            //Application.Run(new ReturnPage());
            //Application.Run(new GreatHallAdmin());
            //Application.Run(new AdminProfile());
            //Application.Run(new ManageBookPage());
            //Application.Run(new EditUserPage());
            //Application.Run(new EditProfilePage());
            //Application.Run(new ViewRequests());
            //Application.Run(new Statistics());
        }
    }

    /*class User
    {
        public string static name ;
        public string password { set; get; }
        public string Email { set; get; }
        public string pos { set; get; }
    }*/

    public class User
    {
        private static User instance;
        public string name {set; get;}
        public string password { set; get; }
        public string Email { set; get; }
        public string pos { set; get; }

        private User()
        {
            // Private constructor to prevent external instantiation
        }

        public static User Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new User();
                }
                return instance;
            }
        }
    }

    class Book
    {
        public string name { set; get; }
        public string ISBN { set; get; }
        public string nCopies { set; get; }
    }
}
