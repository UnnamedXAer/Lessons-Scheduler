using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lessons_Scheduler
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
            
            var maindashboard = new MainDashboardForm();
            maindashboard.Show();
        }

        private void StartForm_MouseEnter(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.AppStarting;
        }

        private void StartForm_MouseLeave(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Default;
        }
    }
}
