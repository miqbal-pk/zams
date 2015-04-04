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
    public partial class BaseControl : UserControl
    {
        public BaseControl()
        {
            InitializeComponent();
        }

        public BaseControl(string title)
        {
            InitializeComponent();
            this.Title.Text = title;
        }
        public BaseControl(string title, string Name)
        {
            InitializeComponent();
            this.Title.Text = title;
            this.Name = Name;
        }

    }
}
