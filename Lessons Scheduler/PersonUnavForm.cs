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
    public partial class PersonUnavForm : Form
    {

        List<PersonUnav> peopleUnav = new List<PersonUnav>();
        List<PersonUnav> peopleUnavDeleted = new List<PersonUnav>();
        List<PersonModel> people = new List<PersonModel>();
        List<KeyValuePair<int, string>> days = new List<KeyValuePair<int, string>>()
          {
              new KeyValuePair<int, string>(0,"Poniedziałek"),
              new KeyValuePair<int, string>(1,"Wtorek"),
              new KeyValuePair<int, string>(2,"Środa"),
              new KeyValuePair<int, string>(3,"Czwartek"),
              new KeyValuePair<int, string>(4,"Piątek"),
          };
        List<KeyValuePair<int, string>> hours = new List<KeyValuePair < int, string>>()
        {
            new KeyValuePair<int, string>(0, "08:00 - 09:30"),
            new KeyValuePair<int, string>(1, "09:45 - 11:15"),
            new KeyValuePair<int, string>(2, "11:30 - 13:00"),
            new KeyValuePair<int, string>(3, "13:15 - 14:45"),
            new KeyValuePair<int, string>(4, "15:00 - 16:30"),
            new KeyValuePair<int, string>(5, "16:45 - 18:15"),
            new KeyValuePair<int, string>(6, "18:30 - 20:00"),
        };


        public PersonUnavForm()
        {
            InitializeComponent();

            WireUpList();
        }

        private void WireUpList()
        {
            SearchPeople();

            peopleListBox.DataSource = people;
            peopleListBox.DisplayMember = "FullName";

            daysListBox.DataSource = days;
            daysListBox.DisplayMember = "Value";
            daysListBox.ValueMember = "Key";

            unavListBox.DataSource = null;
            unavListBox.DataSource = peopleUnav;
            unavListBox.DisplayMember = "FullName";

            hoursListBox.DataSource = hours;
            hoursListBox.DisplayMember = "Value";
            hoursListBox.ValueMember = "Key";
        }

        private void moveRightButton_Click(object sender, EventArgs e)
        {
            var _per = peopleListBox.SelectedItem;
            var _day = daysListBox.SelectedItem;
            var _hourNo = hoursListBox.SelectedValue;
            var _hourName = ((KeyValuePair<int,string>)hoursListBox.SelectedItem).Value;

            if (_hourNo != null && _day != null && _per != null)
            {
                var perUnav = new PersonUnav();
                perUnav.Per = (PersonModel)_per;
                perUnav.Day = (KeyValuePair<int, string>)_day;
                perUnav.HourNo = (int)_hourNo;
                bool isOk = true;


                foreach (var perU in peopleUnav)
                {
                    if (perU.Day.Key == perUnav.Day.Key && perU.Per.Id == perUnav.Per.Id
                        && perUnav.HourNo == perU.HourNo)
                        isOk = false;
                }

                if (isOk)
                {
                    peopleUnav.Add(perUnav);

                    unavListBox.DataSource = null;
                    unavListBox.DataSource = peopleUnav;
                    unavListBox.DisplayMember = "FullName";
                }
            }
        }

        private void moveLeftButton_Click(object sender, EventArgs e)
        {
            var selectedItem = (PersonUnav)unavListBox.SelectedItem;
            if (selectedItem != null)
            {
                peopleUnavDeleted.Add(selectedItem); // TODO - add remove function !!!
                peopleUnav.Remove(selectedItem);//((PersonUnav)unavListBox.SelectedItem);

                unavListBox.DataSource = null;
                unavListBox.DataSource = peopleUnav;
                unavListBox.DisplayMember = "FullName";
            }
        }

        private void savePersonUnavButton_Click(object sender, EventArgs e)
        {
            var _perId = ((PersonModel)peopleListBox.SelectedItem).Id;
            if (!GlobalConfig.Connection.DeletePersonUnav(_perId) || !GlobalConfig.Connection.SavePersonUnav(peopleUnav, 0))
            {
                MessageBox.Show("Coś poszło nie tak. Odśwież opcje i sprawdź poprawność danych.", "Uwaga", MessageBoxButtons.OK);
            }
            else
            {
                WireUpList();
            }

        }

        private void peopleListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var _per = (PersonModel)peopleListBox.SelectedValue;
            var x1 = GlobalConfig.Connection.GetPersonUnav(((PersonModel)_per).Id, 0);
            peopleUnav= new List<PersonUnav>();
            foreach (var item in x1.DayAndHour)
            {
                var perUnav = new PersonUnav();
                perUnav.Per = (PersonModel)_per;
                perUnav.Day = days[item.dayNo];
                perUnav.HourNo = (int)item.hourNo;

                peopleUnav.Add(perUnav);
            }
            unavListBox.DataSource = null;
            unavListBox.DataSource = peopleUnav;
            unavListBox.DisplayMember = "FullName";
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            WireUpList();
        }

        private void SearchPeople()
        {
            peopleUnav = new List<PersonUnav>();
            peopleUnavDeleted = new List<PersonUnav>();

            people = GlobalConfig.Connection.GetPerson(
                -1,
                firstNameSearchBox.Text,
                lastNameSearchBox.Text
                );
        }
    }
}
