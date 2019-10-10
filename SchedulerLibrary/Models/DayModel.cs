using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulerLibrary.Models
{
    public class DayModel
    {
        public int Id { get; set; }
        public int DayNo { get; set; }
        public List<HourModel> Hours = new List<HourModel>();

        public string GetDayName()
        {
            switch (DayNo)
            {
                case 0:
                    return "Poniedziałek";
                //break;
                case 1:
                    return "Wtorek";
                //break;
                case 2:
                    return "Środa";
                //break;
                case 3:
                    return "Czwartek";
                //break;
                case 4:
                    return "Piątek";
                //break;
                case 5:
                    return "Sobota";
                //break;
                case 6:
                    return "Niedziela";
                //break;
                default:
                    return "?";
                    //break;
            }
        }
    }
}
