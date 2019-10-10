using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulerLibrary.Models
{
    /// <summary>
    /// Represents a plan for one Group for all days in week.
    /// </summary>
    public class PlanModel
    {
        /// <summary>
        /// Unique identifier for this Plan.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Represents an id of Gruoup for this plan.
        /// </summary>
        public int GroupId { get; set; }

        /// <summary>
        /// Represents a list of all Lesson for this plan.
        /// </summary>
        public List<LessonModel> Lessons { get; set; } = new List<LessonModel>();
    }
}
