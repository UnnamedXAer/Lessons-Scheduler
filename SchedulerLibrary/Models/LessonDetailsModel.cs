using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulerLibrary.Models
{
    public class LessonDetailsModel
    {
        public int Id { get; set; }
        public PersonModel Teacher { get; set; }
        public RoomModel Room { get; set; }
        public SubjectModel Subject { get; set; }

        public LessonDetailsModel(LessonModel lesson)
        {
            this.Id = lesson.Id;
            Teacher = GlobalConfig.Connection.GetTeacher(lesson.TeacherId);
            Room = GlobalConfig.Connection.GetRoom(lesson.RoomId);
            Subject = GlobalConfig.Connection.GetSubjects(lesson.SubjectId)[0];
        }
    }
}
