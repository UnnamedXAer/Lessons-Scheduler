using SchedulerLibrary;
using SchedulerLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lessons_Scheduler.SearchFroms
{
    public partial class SearchPersonFrom : Form, IPersonRequestor
    {
        ISearchPersonRequestor callingForm;
        List<PersonModel> people;
        public SearchPersonFrom(ISearchPersonRequestor caller)
        {
            InitializeComponent();
            callingForm = caller;
            peopleDataGridView.AutoGenerateColumns = false;
            FillData();

        }

        private void FillData()
        {
            people = GlobalConfig.Connection.GetPerson(
                -1,
                firstNameSearchBox.Text,
                lastNameSearchBox.Text
                );

            peopleDataGridView.AutoGenerateColumns = false;
            peopleDataGridView.DataSource = people;
            peopleDataGridView.Refresh();
        }

        public void PeopleComplete()
        {
            FillData();
        }

        private void hidePersonSearchButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void peopleDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                PersonModel m = GetCheckedPerson(e.RowIndex);
                this.callingForm.SearchPersonComplete(m);
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FillData();
        }

        private PersonModel GetCheckedPerson(int i)
        {
            /*var checkedRows = from DataGridViewRow r in peopleDataGridView.Rows
                              where Convert.ToBoolean(r.Cells[0].Value) == true
                              select (int)r.Cells["Id"].Value;
                              */

            DataGridViewRow row = this.peopleDataGridView.Rows[i];
            var perId = int.Parse(row.Cells["Id"].Value.ToString());

            return people.First(p => p.Id == perId);
        }

        private void peopleDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1 && e.RowIndex >= 0)
            {
                PersonModel m = GetCheckedPerson(e.RowIndex);
                this.callingForm.SearchPersonComplete(m);
                this.Close();
            }
        }

        private void openPersonFormLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreatePersonForm frm = new CreatePersonForm(this);
            frm.ShowDialog();
        }
    }
}
