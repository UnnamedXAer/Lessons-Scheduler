using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulerLibrary.Models
{
    public class SubsWithTeacherComparer : IEqualityComparer<SubjectWithTeacherModel>
    {
        public new bool Equals(SubjectWithTeacherModel x, SubjectWithTeacherModel y)
        {
            return x.Id == y.Id;
        }

        public int GetHashCode(SubjectWithTeacherModel obj)
        {
            unchecked
            {
                if (obj == null)
                    return 0;
                int hashCode = obj.Id.GetHashCode();
                hashCode = (hashCode * 397) ^ obj.Id.GetHashCode();
                return hashCode;
            }
        }
    }
}
