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
    public partial class NewDealer : BaseControl
    {
        public NewDealer()
        {
            InitializeComponent();
        }

        public NewDealer(string title):base(title, "Dealer")
        {
            InitializeComponent();            
        }

        private void NewDealer_Load(object sender, EventArgs e)
        {

        }
    }
}
