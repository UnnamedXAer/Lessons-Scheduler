using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulerLibrary.Models
{
    public class DayHour
    {
        public int dayNo;
        public int hourNo;

        public DayHour()
        {

        }

        public DayHour(int dNo, int hNo)
        {
            dayNo = dNo;
            hourNo = hNo;
        }
    }
}
