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
    public partial class CreatePersonForm : Form
    {
        IPersonRequestor callingForm;
        public CreatePersonForm(IPersonRequestor caller)
        {
            InitializeComponent();

            callingForm = caller;
        }

        private void addPersonButton_Click(object sender, EventArgs e)
        {

            if (ValidateForm())
            {
                PersonModel model = new PersonModel(
                    firstNameTextBox.Text,
                    lastNameTextBox.Text,
                    degreeTextBox.Text,
                    identifierTextBox.Text
                );

                GlobalConfig.Connection.CreatePerson(model);

                firstNameTextBox.Text = "";
                lastNameTextBox.Text = "";
                degreeTextBox.Text = "";
                identifierTextBox.Text = "";
            }
            else
            {
                MessageBox.Show("Popraw wartości w zaznaczonych polach.", "Uwaga!", MessageBoxButtons.OK);
            }
        }

        public bool ValidateForm()
        {
            bool isOk = true;
            if (!ValidateTextBox(firstNameTextBox))
                isOk = false;
            if (!ValidateTextBox(lastNameTextBox))
                isOk = false;
            return isOk;
        }

        private bool ValidateTextBox(TextBox tBox)
        {
            if (tBox.Text == "")
            {
                tBox.BackColor = Color.LemonChiffon;
                return false;
            }
            else
            {
                tBox.BackColor = Color.White;
                return true;
            }
        }

        private void CreatePersonForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (callingForm != null)
                callingForm.PeopleComplete();
        }
    }
}
