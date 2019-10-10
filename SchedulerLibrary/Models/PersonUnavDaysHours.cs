using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulerLibrary.Models
{
    /// <summary>
    /// Represents a list of busy hours for specyfic person.
    /// </summary>
    public class PersonUnavDaysHours
    {
        public int PerId { get; set; }
        public List<DayHour> DayAndHour { get; set; }

        public PersonUnavDaysHours()
        {

        }

        public PersonUnavDaysHours(int perId, List<DayHour> dayAndHour)
        {
            this.PerId = perId;
            this.DayAndHour = dayAndHour;
        }
    }
}
