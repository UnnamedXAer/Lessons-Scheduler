using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulerLibrary.Models
{
    public class PlanModelForPerson
    {
        //public string PersonFullName { get; set; }
        public string SubjectFullName { get; set; }
        public string GroupFullName { get; set; }
        public int SubjectType { get; set; }
        public int DayNo { get; set; }
        public int HourNo { get; set; }
        public string SubjectColor { get; set; }
        public string RoomFullName { get; set; }
        public string SubgroupName { get; set; }

        public string GetHourTime(int hNo)
        {
            return hoursTranslationtable[hNo];
        }

        public string GetLessonTypeName(int typeNo)
        {
            return lessonTypeTranslationTable[typeNo];
        }

        private List<string> lessonTypeTranslationTable = new List<string>()
        {
            "",
            "Wykład",
            "Ćwiczenia",
            "Laboratorium",
            "Projekt"
        };

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

        public PlanModelForPerson()
        {

        }

        public PlanModelForPerson(/*string per,*/ string sub, int subType, string gr, int dNo, int hNo, string subColor, string room,string subgroupName)
        {
            //PersonFullName = per;
            SubjectFullName = sub;
            SubjectType = subType;
            GroupFullName = gr;
            DayNo = dNo;
            HourNo = hNo;
            SubjectColor = subColor;
            RoomFullName = room;
            SubgroupName = subgroupName;
        }
    }
}
