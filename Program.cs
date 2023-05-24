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
        }
    }

    class User
    {
        public string name { set; get; }
        public string password { set; get; }
        public string Email { set; get; }
        public string pos { set; get; }
    }

    class Book
    {
        public string name { set; get; }
        public string ISBN { set; get; }
        public string nCopies { set; get; }
    }
}
