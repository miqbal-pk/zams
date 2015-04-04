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
    public partial class NewProject : BaseControl
    {
        public NewProject()
        {
            InitializeComponent();
        }

       public NewProject(string title):base(title, "Companies")
        {
            InitializeComponent();
        }
    }
}
