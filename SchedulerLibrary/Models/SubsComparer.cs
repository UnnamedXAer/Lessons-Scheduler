using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulerLibrary.Models
{
    public class SubsComparer : IEqualityComparer<SubjectModel>
    {
        public new bool Equals(SubjectModel x, SubjectModel y)
        {
            return x.Id == y.Id;
        }

        public int GetHashCode(SubjectModel obj)
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
