using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_Hotel
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        public static HotelDBEntities Db { get; set; } = new HotelDBEntities();
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }

    }
}
