using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulerLibrary.Models
{
    public class HourModel
    {
        public int HourNo { get; set; }
        private int _slotMax;

        public int SlotsMax { get { return _slotMax; }
            set {
                _slotMax = value;
                SlotsReserved = new int[_slotMax];
                for (int i = 0; i < _slotMax; i++)
                {
                    SlotsReserved[i] = 0;
                }
            }
        }

        public int[] SlotsReserved { get; set; }

        public HourModel()
        {

        }

        public HourModel(int hNo, int sMax)
        {
            HourNo = hNo;
            SlotsMax = sMax;
        }
    }
}
