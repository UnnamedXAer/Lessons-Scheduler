using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulerLibrary.Models
{
    /// <summary>
    /// Represents subgroups od group eg. Exercise groups, labroratory groups, lecture group...
    /// </summary>
    public class SubgroupModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Type { get; set; }
        public int StudentsCnt { get; set; }

        /// <summary>
        /// Represents number of group eg. proj > 2 <
        /// </summary>
        public int GrNo { get; set; }

        public SubgroupModel()
        {

        }

        public SubgroupModel(int id, string name, int type, int studCnt, int grNo)
        {
            this.Id = id;
            this.Name = name;
            this.Type = type;
            this.StudentsCnt = studCnt;
            this.GrNo = grNo;
        }
    }
}
