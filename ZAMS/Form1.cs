using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZAMS
{
    public partial class ParentForm : Form
    {
        public static string LoadedUCName = string.Empty;
        public static List<UserControl> Screens;
        BaseControl bc;
        public ParentForm()
        {
            InitializeComponent();
            Screens = new List<UserControl>();
            initializeForms();
        }

        private void newProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        #region Registry and Loader
        public void initializeForms()
        {
            Screens.Add(new Companies(Program.UCTitle_Company));
            Screens.Add(new Dealer(Program.UCTitle_Dealer));
            Screens.Add(new Projects(Program.UCTitle_Project));
            Screens.Add(new ReportHome(Program.UCTitle_Reports));
            Screens.Add(new SearchTransactions(Program.UCTitle_SearchTransactions));
            Screens.Add(new NewCompany(Program.UCTitle_NewCompany));
            Screens.Add(new NewProject(Program.UCTitle_NewProject));
            Screens.Add(new NewDealer(Program.UCTitle_NewDealer));

        }

        /// <summary>
        /// Deloads the Already Loaded User Control and Loads a new one from the list.
        /// </summary>
        /// <param name="Name"></param>
        public void LoadUserControl(string Name)
        {
            bc = (BaseControl)Screens.Where(p => p.Name.Equals(Name)).FirstOrDefault();
            if (ContentPanel.Controls.Contains(bc))
            {
                //Do Nothing, Just Bring to Front
            }
            else
            {
                this.ContentPanel.Controls.Add(bc);
            } 
            bc.BringToFront();
            this.ContentPanel.Update();
        }

        #endregion

        #region Main Link Controls
        private void link_Companies_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoadUserControl("Companies");
        }

        private void link_Dealers_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoadUserControl("Dealer");
        }

        private void link_Projects_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoadUserControl("Projects");
        }

        private void link_Reports_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoadUserControl("ReportHome");
        }

        private void link_SearchTransactions_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoadUserControl("SearchTransactions");
        }

        #endregion
    }
}
