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
    public partial class CreateSubjectForm : Form//, IPersonRequestor
    {
        //ListBox currentListBox;

        public CreateSubjectForm()
        {
            InitializeComponent();
            /// 1 - lecture
            /// 2 - exercises
            /// 3 - laboratory
            /// 4 - project
       /*     typeComboBox.Items.Add(new KeyValuePair<int, string>(1, "Wykład"));
            typeComboBox.Items.Add(new KeyValuePair<int, string>(2, "Ćwiczenia"));
            typeComboBox.Items.Add(new KeyValuePair<int, string>(3, "Laboratorium"));
            typeComboBox.Items.Add(new KeyValuePair<int, string>(4, "Projekt"));
            typeComboBox.DisplayMember = "Value";
            typeComboBox.ValueMember = "Key";
            typeComboBox.SelectedItem = 1;
            */
            //currentListBox = lecPerListBox;
            //lecPerListBox.BackColor = Color.Aquamarine;
            //exPerListBox.Enabled = exHourNoTextBox.Enabled =ExerciseCheckBox.Checked;
            //labHourNoTextBox.Enabled = labPerListBox.Enabled =LaboratoryCheckBox.Checked;
            //projPerListBox.Enabled = projHourNoTextBox.Enabled =projectCheckBox.Checked;
        }

        private void addRoomButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                SubjectModel model;
                var color = "RGBA(" + subjectColorDialog.Color.R + ","
                    + subjectColorDialog.Color.G + ","
                    + subjectColorDialog.Color.B + ","
                    + subjectColorDialog.Color.A + ")";
                //KeyValuePair<int, string> selectedEntry = (KeyValuePair<int, string>)typeComboBox.SelectedItem;
                if (lecturecCheckBox.Checked)
                {
                    model = new SubjectModel(
                        -1, /*when -1 do NOT assign Id*/
                        nameTextBox.Text,
                        1,
                        30,//int.Parse(lecHourNoTextBox.Text != "" ? lecHourNoTextBox.Text : "30"),
                        color
                    );
                    GlobalConfig.Connection.CreateSubject(model);
                }
                if (ExerciseCheckBox.Checked)
                {
                    model = new SubjectModel(
                        -1, /*when -1 do NOT assign Id*/
                        nameTextBox.Text,
                        2,
                        30,//int.Parse(exHourNoTextBox.Text != "" ? exHourNoTextBox.Text : "30"),
                        color
                    );
                    GlobalConfig.Connection.CreateSubject(model);
                }
                if (LaboratoryCheckBox.Checked)
                {
                    model = new SubjectModel(
                        -1, /*when -1 do NOT assign Id*/
                        nameTextBox.Text,
                        3,
                        30,//int.Parse(labHourNoTextBox.Text != "" ? labHourNoTextBox.Text : "30"),
                        color
                    );
                    GlobalConfig.Connection.CreateSubject(model);
                }
                if (projectCheckBox.Checked)
                {
                    model = new SubjectModel(
                        -1, /*when -1 do NOT assign Id*/
                        nameTextBox.Text,
                        4,
                        30,//int.Parse(projHourNoTextBox.Text != "" ? projHourNoTextBox.Text: "30"),
                        color
                    );
                    GlobalConfig.Connection.CreateSubject(model);
                }

                MessageBox.Show("Przedmiot dodany.", "", MessageBoxButtons.OK);
                ClearFields();
                //GlobalConfig.Connection.CreateSubject(model, GetCheckedPeople());

            }
            else
            {
                MessageBox.Show("Popraw bądź uzupełnij zaznaczone pola.", "Uwaga!", MessageBoxButtons.OK);
            }
        }

        private bool ValidateForm()
        {
            bool isOk = true;
            if (nameTextBox.Text == "")
            {
                nameTextBox.BackColor = Color.LemonChiffon;
                isOk = false;
            }
            else
            {
                nameTextBox.BackColor = Color.White;
            }
           /* if (hoursNoTextBox.Text == "")
            {
                hoursNoTextBox.BackColor = Color.LemonChiffon;
                isOk = false;
            }
            else
            {
                hoursNoTextBox.BackColor = Color.White;
            }*/
        /*    if (lecturecCheckBox.Checked == true)
            {
                if (lecPerListBox.Items.Count != 1)
                {
                    lecPerListBox.BackColor = Color.LemonChiffon;
                    isOk = false;
                }
                else
                {
                    lecPerListBox.BackColor = Color.White;
                }
            }
            else
            {
                lecPerListBox.BackColor = Color.White;
            }
            if (ExerciseCheckBox.Checked == true)
            {
                if (exPerListBox.Items.Count != 1)
                {
                    exPerListBox.BackColor = Color.LemonChiffon;
                    isOk = false;
                }
                else
                {
                    exPerListBox.BackColor = Color.White;
                }
            }
            else
            {
                exPerListBox.BackColor = Color.White;
            }
            if (LaboratoryCheckBox.Checked == true)
            {
                if (labPerListBox.Items.Count != 1)
                {
                    labPerListBox.BackColor = Color.LemonChiffon;
                    isOk = false;
                }
                else
                {
                    labPerListBox.BackColor = Color.White;
                }
            }
            else
            {
                labPerListBox.BackColor = Color.White;
            }
            if (projectCheckBox.Checked == true)
            {
                if (projPerListBox.Items.Count != 1)
                {
                    projPerListBox.BackColor = Color.LemonChiffon;
                    isOk = false;
                }
                else
                {
                    projPerListBox.BackColor = Color.White;
                }
            }
            else
            {
                projPerListBox.BackColor = Color.White;
            }*/

            if (colorPanel.BackColor == Color.White)
            {
                colorButton.BackColor = Color.LemonChiffon;
                isOk = false;
            }
            else
            {
                colorButton.BackColor = Color.WhiteSmoke;
            }
            //currentListBox = null;
            return isOk;
        }

    /*    private KeyValuePair<int,string> GetCheckedPeople()
        {
            if (peopleDataGridView.SelectedRows.Count > 0)
            {
                var checkedRow = peopleDataGridView.SelectedRows[0];
                return new KeyValuePair<int, string>((int)(checkedRow.Cells[1].Value), (string)checkedRow.Cells[3].Value);
            }
            else
                return new KeyValuePair<int, string>();
        }*/

        private void CreateSubjectForm_Load(object sender, EventArgs e)
        {
            /*List<PersonModel> people = GlobalConfig.Connection.GetPerson();

            peopleDataGridView.AutoGenerateColumns = false;
            peopleDataGridView.DataSource = people;*/
        }

    /*    private void searchButton_Click(object sender, EventArgs e)
        {
            FillPersonDataGridView();
        }*/

    /*    private void FillPersonDataGridView()
        {
            List<PersonModel> people = GlobalConfig.Connection.GetPerson(
                -1,
                firstNameSearchBox.Text,
                lastNameSearchBox.Text
                );

            peopleDataGridView.AutoGenerateColumns = false;
            peopleDataGridView.DataSource = people;
            peopleDataGridView.Refresh();
        }*/

/*        private void openPersonFormLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreatePersonForm frm = new CreatePersonForm(this);
            frm.Show();
        }
*/
    /*    public void PeopleComplete()
        {
            FillPersonDataGridView();
        }*/

        private void ExerciseCheckBox_CheckedChanged(object sender, EventArgs e)
        { // TODO - do something with this shit
            //exPerListBox.Enabled = exHourNoTextBox.Enabled = ((CheckBox)sender).Checked;
        }

        private void lecturecCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            //lecPerListBox.Enabled = lecHourNoTextBox.Enabled = ((CheckBox)sender).Checked;
        }

        private void LaboratoryCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            //labPerListBox.Enabled = labHourNoTextBox.Enabled = ((CheckBox)sender).Checked;
        }

        private void projectCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            //projPerListBox.Enabled = projHourNoTextBox.Enabled = ((CheckBox)sender).Checked;
        }

        private void teachersListBox_Click(object sender, EventArgs e)
        {
        /*    ListBox _sender = (ListBox)sender;
            currentListBox = _sender;

            _sender.SelectedItem = null;

            if (_sender.Name == "lecPerListBox")
            {
                lecPerListBox.BackColor = Color.Aquamarine;
                exPerListBox.BackColor = Color.White;
                labPerListBox.BackColor = Color.White;
                projPerListBox.BackColor = Color.White;
            }
            else if (_sender.Name == "exPerListBox")
            {
                lecPerListBox.BackColor = Color.White;
                exPerListBox.BackColor = Color.Aquamarine;
                labPerListBox.BackColor = Color.White;
                projPerListBox.BackColor = Color.White;
            }
            else if (_sender.Name == "labPerListBox")
            {
                lecPerListBox.BackColor = Color.White;
                exPerListBox.BackColor = Color.White;
                labPerListBox.BackColor = Color.Aquamarine;
                projPerListBox.BackColor = Color.White;
            }
            else if (_sender.Name == "projPerListBox")
            {
                lecPerListBox.BackColor = Color.White;
                exPerListBox.BackColor = Color.White;
                labPerListBox.BackColor = Color.White;
                projPerListBox.BackColor = Color.Aquamarine;
            }*/
        }

    /*    private void leftButton_Click(object sender, EventArgs e)
        {
            var per = GetCheckedPeople();
            //currentListBox.DataSource = per;
            if (per.Key != 0 && currentListBox != null)
            {
                currentListBox.DataSource = new List<KeyValuePair<int, string>>() { per };
                currentListBox.DisplayMember = "Value";
                currentListBox.SelectedItem = null;
            }
        }*/

    /*    private void peopleDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
                peopleDataGridView.Rows[e.RowIndex].Selected = true;
        }
*/
   /*     private void peopleDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                peopleDataGridView.Rows[e.RowIndex].Selected = true;
                var per = GetCheckedPeople();
                //currentListBox.DataSource = per;
                if (per.Key != 0 && currentListBox != null)
                {
                    currentListBox.DataSource = new List<KeyValuePair<int, string>>() { per };
                    currentListBox.DisplayMember = "Value";
                    currentListBox.SelectedItem = null;
                }
            }
        }
*/
        private void colorButton_Click(object sender, EventArgs e)
        {
            subjectColorDialog.ShowDialog();
            colorPanel.BackColor = subjectColorDialog.Color;
        }
        private void ClearFields()
        {
            nameTextBox.Text = "";
            colorPanel.BackColor = Color.White;

            //lecPerListBox.DataSource = null;
            //exPerListBox.DataSource = null;
            //labPerListBox.DataSource = null;
            //projPerListBox.DataSource = null;
            /*
            lecturecCheckBox.Checked = true;
            ExerciseCheckBox.Checked = true;
            LaboratoryCheckBox.Checked = true;
            projectCheckBox.Checked = true;
            */
            colorButton.BackColor = Color.White;
        }
    }
}
