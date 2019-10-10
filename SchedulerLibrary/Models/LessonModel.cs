using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulerLibrary.Models
{
    /// <summary>
    /// Represents one lesson.
    /// </summary>
    public class LessonModel
    {
        /// <summary>
        /// unique identifier for Lesson
        /// </summary>
        public int Id { get; set; }


        /// <summary>
        /// pointer to GroupModel ????
        /// </summary>
        public int GroupId { get; set; }

        /// <summary>
        /// pointer to DayModel
        /// </summary>

        /// <summary>
        /// pointer to room (RoomModel).
        /// </summary>
        public int RoomId { get; set; }

        /// <summary>
        /// Pointer to teacher (PersonModel).
        /// </summary>
        public int TeacherId { get; set; }

        /// <summary>
        /// Pointer to subject (SubjectModel)
        /// </summary>
        public int SubjectId { get; set; }

        public int DayNo { get; set; }
        public int HourNo { get; set; }
        public int SlotNo { get; set; }


        public LessonModel()
        {

        }

        public LessonModel(int id, int gid, int rid, int tid, int sid, int dno, int hno, int sno)
        {
            Id = id;
            GroupId = gid;
            RoomId = rid;
            TeacherId = tid;
            SubjectId = sid;
            DayNo = dno;
            HourNo = hno;
            SlotNo = sno;
        }
       // public DayModel Day { get; set; }
    }
}
