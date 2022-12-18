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
    public partial class NewCompany : BaseControl
    {
        public NewCompany()
        {
            InitializeComponent();
        }
         public NewCompany(string title):base(title, "NewhCompany")
        {
            InitializeComponent();
        }


        private void NewCompany_Load(object sender, EventArgs e)
        {

        }
    }
}
