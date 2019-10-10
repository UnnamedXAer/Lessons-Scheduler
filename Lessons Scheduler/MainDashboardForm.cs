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

namespace Lessons_Scheduler
{
    public partial class MainDashboardForm : Form, IPersonRequestor, ISearchGroupRequestor
    {

        public MainDashboardForm()
        {
            this.Enabled = false;
            SchedulerLibrary.GlobalConfig.InitializeConnections(SchedulerLibrary.DatabaseType.SQLite);
            SchedulerLibrary.DataAccess.SQLiteDBFile.CreateDBFile();
            SchedulerLibrary.GlobalConfig.Connection.SetSetup();
            this.Enabled = true;
            InitializeComponent();
            //exitButtons.SetDownButtonOnClick = MinimalizeWindow;
            //exitButtons.SetXButtonOnClick = CloseWindow;
        }

        private void MinimalizeWindow(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void CloseWindow(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateLessonForm frm = new CreateLessonForm();
            frm.ShowDialog();
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SearchFroms.SearchGroupForm frm = new SearchFroms.SearchGroupForm((ISearchGroupRequestor)this);
            frm.ShowDialog();
        }

        public void PeopleComplete()
        {
            
        }

        public void SearchGroupComplete(GroupModel model)
        {
            
        }

        private void lessonGeneratorButton_Click(object sender, EventArgs e)
        {
            LessonGeneratorForm frm = new LessonGeneratorForm();
            frm.ShowDialog();
        }

        private void assignSubjectsButton_Click(object sender, EventArgs e)
        {
            AssignSubs2GroupForm frm = new AssignSubs2GroupForm();
            frm.Show();
        }

        private void setPersonUnavButton_Click(object sender, EventArgs e)
        {
            PersonUnavForm frm = new PersonUnavForm();
            frm.ShowDialog();
        }

        private void createGroupButton_Click(object sender, EventArgs e)
        {
            CreateGroupForm frm = new CreateGroupForm();
            frm.ShowDialog();
        }

        private void createSubjectButton_Click(object sender, EventArgs e)
        {
            CreateSubjectForm frm = new CreateSubjectForm();
            frm.Show();
        }

        private void createPersonButton_Click(object sender, EventArgs e)
        {
            CreatePersonForm frm = new CreatePersonForm((IPersonRequestor) this);
            frm.ShowDialog();
        }

        private void createRoomButton_Click(object sender, EventArgs e)
        {
            CreateRoomForm frm = new CreateRoomForm();
            frm.ShowDialog();
        }

        private void plansInfoButton_Click(object sender, EventArgs e)
        {
            PlansDetailsForm frm = new PlansDetailsForm();
            frm.Show();
        }

        private void createSymmaryForPeopleButton_Click(object sender, EventArgs e)
        {
            CreateSummaryForPerson frm = new CreateSummaryForPerson();
            frm.Show();
        }

        private void AssignSubsOldButton_Click(object sender, EventArgs e)
        {
            RoomsForm frm = new RoomsForm();
            frm.ShowDialog();
        }

        private void AbutLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LessonSchedulerAboutBox frm = new LessonSchedulerAboutBox();
            frm.Show();
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            SetupForm frm = new SetupForm();
            frm.ShowDialog();
        }

        private void MainDashboardForm_Load(object sender, EventArgs e)
        {
        }

        private void MainDashboardForm_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
    }
}
