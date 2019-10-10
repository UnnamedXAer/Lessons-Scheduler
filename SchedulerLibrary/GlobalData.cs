using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulerLibrary
{
    public static class GlobalData
    {
      /*  public static DateTime LessonDuration { get; set; }
        public static DateTime StartHour { get; set; }
        public static int hoursInDay;

        static GlobalData()
        {
            LessonDuration = new DateTime(0, 0, 0, 1, 30, 0);
            StartHour = new DateTime(0, 0, 0, 8, 0, 0);
            hoursInDay = 7;
        }*/

        public static string Path4Groups = "";
        public static string Path4People = "";
        public static int MaxLessonsPerDay;

        public static string GetDayName(int dayNo)
        {
            switch (dayNo)
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

        private static List<string> hoursTranslationtable = new List<string>()
        {
            "08:00 - 09:30",
            "09:45 - 11:15",
            "11:30 - 13:00",
            "13:15 - 14:45",
            "15:00 - 16:30",
            "16:45 - 18:15",
            "18:30 - 20:00"
        };

        public static string GetHourTime(int hNo)
        {
            if (hNo > 6)
                return "?";
            return hoursTranslationtable[hNo];
            }
    }
}
