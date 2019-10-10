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
    public partial class CreateRoomForm : Form
    {
        public CreateRoomForm()
        {
            InitializeComponent();
        }

        private void addRoomButton_Click(object sender, EventArgs e)
        {
            // TODO - Check if róm is not in system.! (check other forms in similar way)
            if (ValidateForm())
            {
                RoomModel model = new RoomModel(
                            roomNoTextBox.Text,
                            wingTextBox.Text,
                            int.Parse(sitsNoTextBox.Text)
                        );

                GlobalConfig.Connection.CreateRoom(model);

                roomNoTextBox.Text = "";
                wingTextBox.Text = "";
                sitsNoTextBox.Text = "";
            }
            else
            {
                MessageBox.Show("Popraw wartości w zaznaczonych polach.", "Uwaga!", MessageBoxButtons.OK);
            }
        }

        public bool ValidateForm()
        {
            bool isOk = true;
            if (!ValidateTextBox(roomNoTextBox))
                isOk = false;
            if (!ValidateTextBox(wingTextBox))
                isOk = false;
            if (sitsNoTextBox.Text != "")
            {
                if (int.TryParse(sitsNoTextBox.Text, out int x))
                {
                    sitsNoTextBox.BackColor = Color.White;
                }
                else
                {
                    sitsNoTextBox.BackColor = Color.LemonChiffon;
                    isOk = false;
                }
            }
            else
            {
                sitsNoTextBox.BackColor = Color.LemonChiffon;
                isOk =  false;
            }

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
    }
}
