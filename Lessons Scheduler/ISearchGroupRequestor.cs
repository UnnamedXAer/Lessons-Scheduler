using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons_Scheduler
{
    public interface ISearchGroupRequestor
    {
        void SearchGroupComplete(SchedulerLibrary.Models.GroupModel model);
    }
}
