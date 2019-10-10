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
    public partial class RoomsForm : Form
    {
        public RoomsForm()
        {
            InitializeComponent();
            roomsDataGridView.AutoGenerateColumns = false;
            WireUpList();
        }

        private List<RoomModel> rooms;

        private void WireUpList()
        {
            rooms = SchedulerLibrary.GlobalConfig.Connection.GetRooms(roomNoTextBox.Text, roomWingTextBox.Text);
            roomsDataGridView.DataSource = null;
            roomsDataGridView.DataSource = rooms;
            roomsDataGridView.Refresh();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            WireUpList();
        }

        private void romoveRoomButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Jesteś pewny, że chcesz usunąć zaznaczone sale?", "Uwaga!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                List<int> roomsIds = new List<int>();
                foreach (DataGridViewRow row in roomsDataGridView.Rows)
                {
                    if (row.Cells.Count > 2 && row.Cells[0].Value != null && (bool)row.Cells[0].Value)
                    {
                        roomsIds.Add((int)row.Cells[1].Value);
                    }
                }
                if (roomsIds.Count > 0)
                {
                    SchedulerLibrary.GlobalConfig.Connection.DeleteRoom(roomsIds);
                }
                WireUpList();
            }
        }
    }
}
