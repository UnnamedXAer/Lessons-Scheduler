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
    public partial class CreateSummaryForPerson : Form
    {
        private List<KeyValuePair<PersonModel, int>> people;
        public CreateSummaryForPerson()
        {
            InitializeComponent();
            Search();
        }

        private void WireUpList(List<KeyValuePair<PersonModel, int>> _people)
        {
            List<PersonModel2> list = new List<PersonModel2>();
            foreach (KeyValuePair<PersonModel, int> pair in _people)
            {
                PersonModel2 per = new PersonModel2();
                per.FirstName = pair.Key.FirstName;
                per.LastName = pair.Key.LastName;
                per.Degree = pair.Key.Degree;
                per.Id = pair.Key.Id;
                per.Identifier = pair.Key.Identifier;
                per.LessonsCnt = pair.Value;
                list.Add(per);
            }

            peopleDataGridView.AutoGenerateColumns = false;
            peopleDataGridView.DataSource = list;
            peopleDataGridView.Refresh();
        }

        private void Search()
        {
            string fn = firstNameSearchBox.Text;
            string ln = lastNameSearchBox.Text;
            var identifier = identifierSearchBox.Text;
            people = GlobalConfig.Connection.GetPeopleToPrintSummary(fn, ln,-1, identifier);

            WireUpList(people);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void selectAllButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in peopleDataGridView.Rows)
            {
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells[1];
                chk.Value = true;
            }
            peopleDataGridView.EndEdit();
        }

        private void UnselectAllButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in peopleDataGridView.Rows)
            {
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells[1];
                chk.Value = false;
            }
            peopleDataGridView.EndEdit();
        }

        private void printPlanButton_Click(object sender, EventArgs e)
        {
            int cnt = 0;
            int checkedCnt = 0;
            foreach (DataGridViewRow row in peopleDataGridView.Rows)
            {
                if (row.Cells.Count > 2 && row.Cells[1].Value != null && (bool)row.Cells[1].Value)
                {
                    checkedCnt++;
                    List<PlanModelForPerson> plan = GlobalConfig.Connection.GetPlanForPerson((int)row.Cells[0].Value);
                    string ans = SchedulerLibrary.Logic.Print.CreateDocumentForPerson((string)row.Cells[3].Value,
                        plan, 
                        toPDFCheckBox.Checked,
                        toHtmlCheckBox.Checked
                        );

                    if (ans != "OK")
                    {
                        var mBoxAns = MessageBox.Show(ans + Environment.NewLine + Environment.NewLine +
                            "Zamknij program używający wspomnianego pliku i spróbuj ponownie.", "Błąd podczas zapisu!", MessageBoxButtons.RetryCancel);
                        if (DialogResult.Retry == mBoxAns)
                        {
                            ans = SchedulerLibrary.Logic.Print.CreateDocumentForPerson((string)row.Cells[3].Value, 
                                plan,
                                toPDFCheckBox.Checked,
                                toHtmlCheckBox.Checked
                                );

                            if (ans != "OK")
                                mBoxAns = MessageBox.Show(ans + Environment.NewLine + Environment.NewLine +
                                    "Nie udało się zapisać planu", "Błąd podczas zapisu!", MessageBoxButtons.OK);
                            else
                                cnt++;
                        }
                    }
                    else
                        cnt++;
                }
            }
            if (checkedCnt > 0)
                MessageBox.Show($"Zapisano {cnt} planów.", "Informacja", MessageBoxButtons.OK);
            else
                MessageBox.Show($"Zaznacz przynajmniej jedną pozycje.", "Informacja", MessageBoxButtons.OK);
        }

        private void deletePersonButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Jesteś pewny, że chcesz usunąć zaznaczone osoby?"
                , "Uwaga!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in peopleDataGridView.Rows)
                {
                    if (row.Cells.Count > 2 && row.Cells[1].Value != null && (bool)row.Cells[1].Value)
                    {
                        int perId = (int)row.Cells[0].Value;
                        string ans = GlobalConfig.Connection.DeletePerson(perId);
                        if (ans != "")
                            MessageBox.Show(ans,"Błąd.", MessageBoxButtons.OK);
                    }
                }
                Search();
            }
        }
    }
}
