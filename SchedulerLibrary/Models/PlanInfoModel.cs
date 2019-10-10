using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulerLibrary.Models
{
    public class GroupPlanInfoModel
    {
        public string GroupName { get; set; }
        public int LessonsCnt { get; set; }
        public int GroupId { get; set; }
        public int SubjectsCnt { get; set; }
        public int GroupYear { get; set; }
        public int GroupStudNo { get; set; }

        public GroupPlanInfoModel()
        {

        }
        public GroupPlanInfoModel(int grId, string grName, int grYear, int lessonsCnt, int subjectsCnt, int grStudNo)
        {
            GroupName = grName;
            GroupId = grId;
            GroupYear = grYear;
            LessonsCnt = lessonsCnt;
            SubjectsCnt = subjectsCnt;
            GroupStudNo = grStudNo;
        }
    }
}
