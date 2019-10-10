using SchedulerLibrary;
using SchedulerLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lessons_Scheduler.SearchFroms
{
    public partial class SearchGroupForm : Form, IGroupRequestor
    {
        ISearchGroupRequestor callingForm;

        public SearchGroupForm(ISearchGroupRequestor caller)
        {
            InitializeComponent();
            callingForm = caller;
        }

        private void lookupGroupCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            FillGroupDataGridView();
        }

        private void lookupDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                GroupModel m = GetCheckedGroup(e.RowIndex);
                this.callingForm.SearchGroupComplete(m);
                this.Close();
            }
        }

        private GroupModel GetCheckedGroup(int i)
        {
            GroupModel model = new GroupModel();
            var checkedRows = from DataGridViewRow r in lookupDataGridView.Rows
                              where Convert.ToBoolean(r.Cells[0].Value) == true
                              select (int)r.Cells["Id"].Value;

            DataGridViewRow row = this.lookupDataGridView.Rows[i];
            model.Id = int.Parse(row.Cells["Id"].Value.ToString());
            model.Name = row.Cells["Name"].Value.ToString();
            model.Year = int.Parse(row.Cells["Year"].Value.ToString());

            return model;
        }

        private void openGroupFormLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateGroupForm frm = new CreateGroupForm(this);
            frm.ShowDialog();
        }

        private void SearchGroupForm_Load(object sender, EventArgs e)
        {
            FillGroupDataGridView();
        }

        private void FillGroupDataGridView()
        {
            Regex regex = new Regex(@"^\d$");
            int y = -1;
            if (0 < (regex.Matches(yearSearchBox.Text).Count))
            {
                y = int.Parse(yearSearchBox.Text);
            }
            List<GroupModel> groups = GlobalConfig.Connection.GetGroup( -1, -1, nameSearchBox.Text, y );

            lookupDataGridView.AutoGenerateColumns = false;
            lookupDataGridView.DataSource = groups;
        }

        private void lookupDataGridView_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            // TODO - text on button
        }

        private void lookupDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                GroupModel m = GetCheckedGroup(e.RowIndex);
                this.callingForm.SearchGroupComplete(m);
                this.Close();
            }
        }

        public void CreateGroupCompleted()
        {
            FillGroupDataGridView();
        }
    }
}
