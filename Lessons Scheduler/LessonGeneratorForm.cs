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
    public partial class LessonGeneratorForm : Form, ISearchGroupRequestor
    {
        private int _grId = -1;

        public int GrId
        {
            get
            {
                return _grId;
            }
            set
            {
                if (value != _grId)
                {
                    _grId = value;
                    //WireUpList();
                }
            }
        }

        public LessonGeneratorForm()
        {
            InitializeComponent();
            MessageBox.Show(GlobalConfig.Connection.saveTestingData(), "test insert",MessageBoxButtons.OK);
        }

        private void Generate( )
        {
            if (GrId != -1)
            {
                System.Diagnostics.Stopwatch stopWatch = new System.Diagnostics.Stopwatch();
                stopWatch.Start();
                EnableButtons(false);
                summaryRichTextBox.Text = "";
                var GeneratorLoop = new GeneratorLoop(GrId);
                string summary = GeneratorLoop.Start();
                summaryRichTextBox.Text = "Więcej informacji w pliku informacyjnym." + Environment.NewLine + Environment.NewLine + summary;
                var time = DateTime.FromBinary(GeneratorLoop.stopWatch.ElapsedMilliseconds);
                EnableButtons(true);
                stopWatch.Stop();
                MessageBox.Show("Czas generowania: " + stopWatch.Elapsed.ToString("mm\\:ss\\.ff"), "Zrobione!", MessageBoxButtons.OK);
                /*MessageBox.Show("Czas generowania: " + time.Minute + ":" +time.Second + ":" + time.Millisecond
                    , "Zrobione!", MessageBoxButtons.OK);*/
            }
        }

        private void EnableButtons(bool enabled)
        {
            generateAllButton.Enabled = enabled;
            lookupGroupButton.Enabled = enabled;
            startGeneratingButton.Enabled = enabled;
        }

        private async Task RunGnerateAsync()
        {
            EnableButtons(false);
            summaryRichTextBox.Text = "";
            Progress<int> progress = new Progress<int>(/*v => { generatorProgressBar.Value = v; }*/);
            progress.ProgressChanged += ReportProgress;
            System.Diagnostics.Stopwatch stopWatch = new System.Diagnostics.Stopwatch();
            stopWatch.Start();
            var groupsNames = "";
            List<GroupModel> groups = GlobalConfig.Connection.GetGroup();
            var i = 0;
            foreach (var group in groups)
            {
                i++;
                var gen = new GeneratorLoop(group.Id);
                currentGeneratedGrNameTextBox.Text = group.Name;

                string summary = "";

                await Task.Run(() => 
                {
                    summary = gen.Start();
                });
                Report(progress, i, groups.Count);
                summaryRichTextBox.Text += (
                      Environment.NewLine
                    + "------------------"
                    + Environment.NewLine
                    + summary);
                groupsNames += Environment.NewLine + group.Name;
            }
            summaryRichTextBox.Text = "Więcej informacji w pliku informacyjnym." + Environment.NewLine + Environment.NewLine + summaryRichTextBox.Text;
            stopWatch.Stop();
            EnableButtons(true);

            MessageBox.Show("Czas generowania: " + stopWatch.Elapsed.ToString("mm\\:ss\\.ff"), "Zrobione!", MessageBoxButtons.OK);
        }

        private void Report(IProgress<int> progress, int pos, int max)
        {
             progress.Report((pos * 100) / max);
        }

        private void ReportProgress(object sender, int e)
        {
            generatorProgressBar.Value = e;
        }

        private void startGeneratingButton_Click(object sender, EventArgs e)
        {
            Generate();
        }

        private void lookupGroupButton_Click(object sender, EventArgs e)
        {
            SearchFroms.SearchGroupForm frm = new SearchFroms.SearchGroupForm(this);
            frm.ShowDialog();
        }

        public void SearchGroupComplete(GroupModel model)
        {
            string year = "";
            switch (model.Year)
            {
                case 1:
                    year = "I";
                    break;
                case 2:
                    year = "II";
                    break;
                case 3:
                    year = "III";
                    break;
                case 4:
                    year = "IV";
                    break;
                default:
                    year = "UNKNOWN!";
                    break;
            }
            groupNameTextBox.Text = model.Name + " " + year;
            GrId = model.Id;
        }

    /*    private void getDaysButton_Click(object sender, EventArgs e)
        {
            if (GrId != -1)
            {
                List<DayModelX> _days = GlobalConfig.Connection.GetDays(GrId);
            }
        }*/

        private void getSubjectsButton_Click(object sender, EventArgs e)
        {
            if (GrId != -1)
            {
                List<SubjectModel> _subjects = GlobalConfig.Connection.GetSubjects(-1, GrId);
            }
        }

        private void clearPalnsButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do You really want erase ALL plans? It can be reversed!","Ahtung!",MessageBoxButtons.YesNo) == DialogResult.Yes)
                GlobalConfig.Connection.ClearPlans();
        }

        private async void generateAllButton_Click(object sender, EventArgs e)
        {
            await RunGnerateAsync();
        }
    }
}
