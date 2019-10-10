using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulerLibrary.Models
{
    public class PersonUnav
    {
        public PersonModel Per { get; set; }
        //public int PerId { get; set; }
        public KeyValuePair<int, string> Day { get; set; }
        public int HourNo { get; set; }
        //public string IsLesson { get; set; }

        public string FullName
        {
            get
            {
                return Per.FullName + " - " + Day.Value + " - " + hoursTranslationtable[HourNo];
                    //+ (IsLesson != "" ? "["+IsLesson+"]" : "");
            }
        }

        private List<string> hoursTranslationtable = new List<string>()
        {
            "08:00 - 09:30",
            "09:45 - 11:15",
            "11:30 - 13:00",
            "13:15 - 14:45",
            "15:00 - 16:30",
            "16:45 - 18:15",
            "18:30 - 20:00"
        };

    }
}
