using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulerLibrary.Models
{
    public class SubjectWithTeacherModel: SubjectModel
    {

        public PersonModel Teacher { get; set; }

        public SubjectWithTeacherModel()
        {

        }

        public string TeacherFullName {
            get
            {
                return Teacher.FullName;
            }
        }

        public SubjectWithTeacherModel(PersonModel teacher, int id, string name, int type ) : base(id, name, type)
        {
            Teacher = teacher;
        }
    }
}
