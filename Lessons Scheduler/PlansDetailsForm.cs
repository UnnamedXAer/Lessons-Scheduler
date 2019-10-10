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

namespace Lessons_Scheduler
{
    public partial class PlansDetailsForm : Form
    {
        private List<GroupPlanInfoModel> plansInfo;
        //string path = ""; // TODO - path to save
        public PlansDetailsForm()
        {
            InitializeComponent();
        }

        private void PlansDetailsForm_Load(object sender, EventArgs e)
        {
        //    plansInfo = GlobalConfig.Connection.GetPlansInfo();
            WireUpList();
        }

        private void WireUpList()
        {
            var name = groupNameSearchBox.Text;
            var ans = int.TryParse(groupYearSearchBox.Text, out int year);
            if (ans != true) year = -1;
            plansInfo = GlobalConfig.Connection.GetPlansInfo(name, year);

            plansDataGridView.AutoGenerateColumns = false;
            plansDataGridView.DataSource = plansInfo;
            plansDataGridView.Refresh();
        }

        private List<LessonModel> GetPlan()
        {
            List<LessonModel> lessons = new List<LessonModel>();

            return lessons;
        }

        private void printPlanButton_Click(object sender, EventArgs e)
        {
            /*if (path != "")
                ;// folderBrowserDialog.RootFolder = path;
            else
                //folderBrowserDialog.RootFolder = Environment.SpecialFolder.MyDocuments;
            folderBrowserDialog.i*/
            //var results= folderBrowserDialog.ShowDialog();
            //path = folderBrowserDialog.SelectedPath;
            int cnt = 0;
            foreach (DataGridViewRow row in plansDataGridView.Rows)
            {
                if (row.Cells.Count > 2 && row.Cells[1].Value != null && (bool)row.Cells[1].Value)
                {
                    cnt++;
                    List<LessonModel> plan = GlobalConfig.Connection.GetPlan((int)row.Cells[0].Value);
                    if (plan.Count == 0)
                        continue;
                    string ans = SchedulerLibrary.Logic.Print.CreateDocument(plan,
                                 toPDFCheckBox.Checked,
                                 toHtmlCheckBox.Checked,
                                 printSummaryCheckBox.Checked);
                    if (ans != "OK")
                    {
                        var mBoxAns = MessageBox.Show("Coś poszło nie tak. " + Environment.NewLine + Environment.NewLine + ans , "Błąd podczas zapisu!", MessageBoxButtons.RetryCancel);
                        if (DialogResult.Retry == mBoxAns)
                        {
                             ans = SchedulerLibrary.Logic.Print.CreateDocument(plan,
                                 toPDFCheckBox.Checked,
                                 toHtmlCheckBox.Checked,
                                 printSummaryCheckBox.Checked);

                            if (ans != "OK")
                                mBoxAns = MessageBox.Show(ans + Environment.NewLine + Environment.NewLine +
                                    "Nie udało się zapisać planu", "Błąd podczas zapisu!", MessageBoxButtons.OK);
                        }
                    }          
                }
            }
            if (cnt > 0)
                MessageBox.Show($"Generowanie plików zakończone.", "Informacja", MessageBoxButtons.OK);
            else
                MessageBox.Show($"Zaznacz przynajmniej jedną pozycje.", "Informacja", MessageBoxButtons.OK);
        }

        private void plansDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2 && e.RowIndex != -1)
            {
                int rowNo = e.RowIndex;
                int grId = (int)plansDataGridView.Rows[rowNo].Cells[0].Value;
                List<LessonModel> plan =  GlobalConfig.Connection.GetPlan(grId);
                var ans = "";
                if (plan.Count > 0)
                    ans = SchedulerLibrary.Logic.Print.CreateDocument(plan);
                if (ans != "" || ans != "OK")
                {
                    MessageBox.Show("Coś poszło nie tak." + Environment.NewLine + Environment.NewLine + ans, "Błąd!", MessageBoxButtons.OK);
                }
            }
        }

        private void UnselectAllButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in plansDataGridView.Rows)
            {
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells[1];
                chk.Value = false;
            }
            plansDataGridView.EndEdit();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            WireUpList();
        }

        private void selectAllButton_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow row in plansDataGridView.Rows)
            {
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells[1];
                chk.Value = true;
            }
            plansDataGridView.EndEdit();
        }

        private void deletePlanButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Jesteś pewny, że chcesz usunąć plany dla zaznaczonych grup?", "Uwaga!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in plansDataGridView.Rows)
                {
                    if (row.Cells.Count > 2 && row.Cells[1].Value != null && (bool)row.Cells[1].Value)
                    {
                        int grId = (int)row.Cells[0].Value;
                        GlobalConfig.Connection.DeletePlan(grId);
                    }
                }
                WireUpList();
            }
        }

        private void deleteGroupButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Jesteś pewny, że chcesz usunąć zaznaczone grupy?"
                , "Uwaga!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in plansDataGridView.Rows)
                {
                    if (row.Cells.Count > 2 && row.Cells[1].Value != null && (bool)row.Cells[1].Value)
                    {
                        int grId = (int)row.Cells[0].Value;
                        GlobalConfig.Connection.DeletePlan(grId);
                        GlobalConfig.Connection.DeleteGroup(grId);
                    }
                }
                WireUpList();
            }
        }
    }
}
