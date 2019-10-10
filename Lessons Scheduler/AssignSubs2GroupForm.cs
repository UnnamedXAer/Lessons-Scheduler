using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SchedulerLibrary.Models;
using SchedulerLibrary;

namespace Lessons_Scheduler
{
    public partial class AssignSubs2GroupForm : Form, ISearchGroupRequestor, ISearchPersonRequestor
    {
        private int grId = -1;
        private List<SubjectModel> notAssignedSubs = new List<SubjectModel>();
        private List<SubjectWithTeacherModel> assignedSubs = new List<SubjectWithTeacherModel>();
        private SubsComparer listsComparer = new SubsComparer();
        private PersonModel teacher;

        public AssignSubs2GroupForm()
        {
            InitializeComponent();
            notAssignedDataGridView.AutoGenerateColumns = false;
            assignedDataGridView.AutoGenerateColumns = false;
        }

        public void SearchGroupComplete(GroupModel model)
        {
            grId = model.Id;
            groupNameTextBox.Text = model.FullName;
            WireUpLists();
        }



        private void notAssignedDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RefreshAssigned()
        {
            assignedDataGridView.DataSource = null;
            assignedSubs = assignedSubs.OrderBy(a => a.Name).ThenBy(a => a.Type).ToList();
            assignedDataGridView.DataSource = assignedSubs;
            assignedDataGridView.Refresh();
        }

        private void RefreshNotAssigned()
        {
            notAssignedDataGridView.DataSource = null;
            notAssignedSubs = notAssignedSubs.OrderBy(nA => nA.Name).ThenBy(nA => nA.Type).ToList();
            notAssignedDataGridView.DataSource = notAssignedSubs;
            notAssignedDataGridView.Refresh();
        }

        private void FullfillAssigned()
        {
            if (grId != -1)
            {
                assignedSubs = GlobalConfig.Connection.GetSubjectsWithTeacher4Group(grId);
                RefreshAssigned();
            }
        }

        private void FullfillNotAssigned()
        {
            notAssignedSubs = GlobalConfig.Connection.GetSubjects(-1, -1, subNameSearchBox.Text).ToList().Except(assignedSubs, listsComparer).ToList();
            //notAssignedSubs = GlobalConfig.Connection.GetSubjectsWithTeacher4Group(-1, subNameSearchBox.Text).Except(assignedSubs, listsComparer).ToList();
            RefreshNotAssigned();
        }

        private void WireUpLists()
        {
            FullfillAssigned();
            FullfillNotAssigned();
        }

        private void AssignSubs2GroupForm_Load(object sender, EventArgs e)
        {
            WireUpLists();
        }

        private void lookupGroupButton_Click(object sender, EventArgs e)
        {
            var frm = new SearchFroms.SearchGroupForm(this);
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            grId = -1;

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            FullfillNotAssigned();
        }

        private void clearSubNameButton_Click(object sender, EventArgs e)
        {
            subNameSearchBox.Text = "";
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (grId != -1)
            {
                groupNameTextBox.BackColor = Color.White;
                if (teacher != null && teacher.Id != 0)
                {
                    teacherTextBox.BackColor = Color.White;
                    var tmpSubs = new List<SubjectWithTeacherModel>();
                    foreach (DataGridViewRow row in notAssignedDataGridView.Rows)
                    {
                        if (row.Cells.Count > 2 && row.Cells[0].Value != null && (bool)row.Cells[0].Value)
                        {
                            int subId = (int)row.Cells[1].Value;
                            //notAssignedDataGridView.Rows.RemoveAt(row.Index);
                            SubjectModel tmpSubject = notAssignedSubs.First(nA => nA.Id == subId);
                            tmpSubs.Add(new SubjectWithTeacherModel(teacher, tmpSubject.Id, tmpSubject.Name, tmpSubject.Type));
                        }
                    }
                    foreach (var item in tmpSubs)
                    {
                        notAssignedSubs.Remove(item);
                    }

                    assignedSubs.AddRange(tmpSubs);
                    RefreshNotAssigned();
                    RefreshAssigned();
                }
                else
                {
                    teacherTextBox.BackColor = Color.LemonChiffon;
                }
            }
            else
            {
                groupNameTextBox.BackColor = Color.LemonChiffon;
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            var tmpSubs = new List<SubjectWithTeacherModel>();
            foreach (DataGridViewRow row in assignedDataGridView.Rows)
            {
                if (row.Cells.Count > 2 && row.Cells[0].Value != null && (bool)row.Cells[0].Value)
                {
                    int subId = (int)row.Cells[1].Value;
                    //notAssignedDataGridView.Rows.RemoveAt(row.Index);
                    tmpSubs.Add(assignedSubs.First(a => a.Id == subId));
                }
            }
            foreach (var item in tmpSubs)
            {
                assignedSubs.Remove(item);
            }
            notAssignedSubs.AddRange(tmpSubs);
            RefreshNotAssigned();
            RefreshAssigned();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (grId != -1 && assignedSubs != null && assignedSubs.Count > 0)
            {
                var ans = GlobalConfig.Connection.UnlinkAndSaveSubsForGroup(grId, assignedSubs);
                if (ans != "")
                    MessageBox.Show(ans, "Uwaga.", MessageBoxButtons.OK);
                else
                    MessageBox.Show("Zmiany  zostały zapisane", "Informacja.", MessageBoxButtons.OK);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var tmpSubsIds = new List<int>();
            foreach (DataGridViewRow row in notAssignedDataGridView.Rows)
            {
                if (row.Cells.Count > 2 && row.Cells[0].Value != null && (bool)row.Cells[0].Value)
                {
                    int subId = (int)row.Cells[1].Value;
                    tmpSubsIds.Add(subId);
                }
            }
            if (tmpSubsIds.Count == 0)
                MessageBox.Show("Żadna pozycja nie została zaznaczona.", "Uwaga", MessageBoxButtons.OK);
            else
            {
                if (MessageBox.Show("Jesteś pewny, że chcesz usunąć przedmiot?","Uwaga", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var ans = GlobalConfig.Connection.DeleteSubjects(tmpSubsIds);
                    if (ans != "")
                        MessageBox.Show(ans, "Uwaga.", MessageBoxButtons.OK);
                    else
                        MessageBox.Show("Zmiany zostały zapisane", "Informacja.", MessageBoxButtons.OK);
                    WireUpLists();
                }
            }
        }

        private void subNameSearchBox_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                FullfillNotAssigned();
            }
        }

        public void SearchPersonComplete(PersonModel model)
        {
            teacher = model;
            teacherTextBox.Text = teacher.FullName;
        }

        private void openPersonLookupButton_Click(object sender, EventArgs e)
        {
            var frm = new SearchFroms.SearchPersonFrom(this);
            frm.ShowDialog();
        }

        private void teacherTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void groupNameTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
