using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZAMS
{
    public static class Program
    {
        public static string UCTitle_Company = "Companies Management";
        public static string UCTitle_Dealer = "Dealers Management";
        public static string UCTitle_Project = "Project Management";
        public static string UCTitle_Reports = "Reports Center";
        public static string UCTitle_SearchTransactions = "Query Transactions";
        public static string UCTitle_NewCompany = "New Company";
        public static string UCTitle_NewProject = "New Project";
        public static string UCTitle_NewDealer = "New Dealer";




        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ParentForm());
        }
    }
}
