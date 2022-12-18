using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZAMS
{
    public partial class Dealer : BaseControl
    {
        public Dealer()
        {
            InitializeComponent();
        }

        public Dealer(string title):base(title, "Dealer")
        {
            InitializeComponent();
            
        }

        private void link_AddCompany_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ParentForm pf = (ParentForm)this.Parent.Parent.Parent;
            pf.LoadUserControl("NewDealer");
        }

        private void Companies_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
