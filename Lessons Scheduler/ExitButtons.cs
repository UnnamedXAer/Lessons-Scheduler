using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lessons_Scheduler
{
    public partial class ExitButtons : UserControl
    {
        public ExitButtons()
        {
            InitializeComponent();
        }

        public System.EventHandler SetXButtonOnClick 
        {
            set { XButton.Click += new System.EventHandler(value); ; }
        }

        public System.EventHandler SetDownButtonOnClick
        {
            set { downButton.Click += new System.EventHandler(value); ; }
        }
    }
}
