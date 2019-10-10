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
    public partial class SetupForm : Form
    {
        private string grPath = "";
        private string pPath = "";



        public SetupForm()
        {
            InitializeComponent();
        }

        private void groupPathTexBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void peoplePathTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupPathLookupButton_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    groupPathTexBox.Text = fbd.SelectedPath;
                    grPath = fbd.SelectedPath;
                }
            }
        }

        private void peoplePathLookupButton_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    peoplePathTextBox.Text = fbd.SelectedPath;
                    pPath = fbd.SelectedPath;
                }
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(maxLessonsTextBox.Text, out int maxLessons))
            {
                var ans = SchedulerLibrary.GlobalConfig.Connection.SaveSetup(grPath, pPath, maxLessons);
                if (ans != "")
                {
                    MessageBox.Show(ans, "Błąd", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Dane zapisane", "Informacja", MessageBoxButtons.OK);
                    SchedulerLibrary.GlobalData.Path4Groups = grPath;
                    SchedulerLibrary.GlobalData.Path4People = pPath;
                    SchedulerLibrary.GlobalData.MaxLessonsPerDay = maxLessons;
                }
            }
            else
                MessageBox.Show("Nieprawidłowa wartośc w polu maksymalnej ilośc lekcji.", "Uwaga", MessageBoxButtons.OK);
        }

        private void SetupForm_Load(object sender, EventArgs e)
        {
            groupPathTexBox.Text = grPath = SchedulerLibrary.GlobalData.Path4Groups;
            peoplePathTextBox.Text = pPath = SchedulerLibrary.GlobalData.Path4People;
            maxLessonsTextBox.Text = $"{SchedulerLibrary.GlobalData.MaxLessonsPerDay}";
        }
    }
}
