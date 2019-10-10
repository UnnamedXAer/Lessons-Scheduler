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
    public partial class CreateGroupForm : Form
    {
        IGroupRequestor caller = null;
        public CreateGroupForm(IGroupRequestor callingForm)
        {
            InitializeComponent();
            caller = callingForm;
        }

        public CreateGroupForm()
        {
            InitializeComponent();
            maxHoursPerDayTextBox.Text = GlobalData.MaxLessonsPerDay.ToString();
        }

        private void addGroupButton_Click(object sender, EventArgs e)
        {
            
            if (ValidateForm())
            {
                GroupModel model = new GroupModel(
                    specializationTextBox.Text,
                    yearTextBox.Text,
                    studentsNoTextBox.Text,
                    exGrNoTextBox.Text,
                    labGrNoTextBox.Text,
                    projGrNoTextBox.Text,
                    maxHoursPerDayTextBox.Text
                );

                GlobalConfig.Connection.CreateGroup(model);

                specializationTextBox.Text = "";
                yearTextBox.Text = "";
                studentsNoTextBox.Text = "";
                exGrNoTextBox.Text = "";
                labGrNoTextBox.Text = "";
                projGrNoTextBox.Text = "";
            }
            else
            {
                MessageBox.Show("Popraw wartości w zaznaczonych polach.", "Uwaga!", MessageBoxButtons.OK);
            }
        }


        private bool ValidateForm()
        {
            // TODO - check if there is less or even number of lecture groups then in other cases.
            bool isOk = true;
            if (specializationTextBox.Text == "")
            {
                specializationTextBox.BackColor = Color.LemonChiffon;
                isOk = false;
            }
            if (!ValidateTextBoxByInt(yearTextBox))
                isOk = false;
            if (!ValidateTextBoxByInt(studentsNoTextBox))
                isOk = false;
            if (!ValidateTextBoxByInt(exGrNoTextBox))
                isOk = false;
            if (!ValidateTextBoxByInt(labGrNoTextBox))
                isOk = false;
            if (!ValidateTextBoxByInt(projGrNoTextBox))
                isOk = false;
            if (!ValidateTextBoxByInt(maxHoursPerDayTextBox))
                isOk = false;

            return isOk;
        }

        private bool ValidateTextBoxByInt(TextBox tBox)
        {
            bool isOk = true;
            int x = 0;
            if (tBox.Text != "")
            {
                bool isInt = int.TryParse(tBox.Text, out x);
                if (!isInt)
                {
                    tBox.BackColor = Color.LemonChiffon;
                    isOk = false;
                }
                else if (x < 1)
                {
                    tBox.BackColor = Color.LemonChiffon;
                    isOk = false;
                }
                else
                {
                    tBox.BackColor = Color.White;
                }
            }
            else
            {
                tBox.BackColor = Color.LemonChiffon;
                isOk = false;
            }
            return isOk;
        }

        private void CreateGroupForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (caller != null)
                caller.CreateGroupCompleted();
        }
    }
}
