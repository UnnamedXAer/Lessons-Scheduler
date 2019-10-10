using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulerLibrary.Models
{
    /// <summary>
    /// Define room in building.
    /// </summary>
    public class RoomModel
    {
        public int Id { get; set; }
        public string RoomNo { get; set; }
        /// <summary>
        /// Reprezents the part of building eg. B2
        /// </summary>
        public string Wing { get; set; }
        public int SitsCnt { get; set; }

        public List<DayHour> DayAndHour { get; set; } = new List<DayHour>();

        public RoomModel(string roomNo, string wing, int sitsCnt, List<DayHour> dayAndHour = null)
        {
            this.RoomNo = roomNo;
            this.Wing = wing;
            this.SitsCnt = sitsCnt;
            this.DayAndHour = dayAndHour;
        }

        public RoomModel(int rId, string roomNo, string wing, int sitsCnt)
        {
            this.Id = rId;
            this.RoomNo = roomNo;
            this.Wing = wing;
            this.SitsCnt = sitsCnt;
        }

        public RoomModel()
        {

        }
    }
}
