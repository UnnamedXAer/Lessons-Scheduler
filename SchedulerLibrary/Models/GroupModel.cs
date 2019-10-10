using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulerLibrary.Models
{
    /// <summary>
    /// Represents a group of students (eg. Mechatronika 1)
    /// </summary>
    public class GroupModel
    {
        public GroupModel()
        {

        }

        public GroupModel(int id, string name, int year, int studCnt, int maxLess)
        {
            this.Id = id;
            this.Name = name;
            this.Year = year;
            this.StudentsCnt = studCnt;
            this.MaxLessonsPerDay = maxLess;
        }

        public GroupModel(int id, string name, int year, int studCnt, List<SubgroupModel> subgroups)
        {
            this.Id = id;
            this.Name = name;
            this.Year = year;
            this.StudentsCnt = studCnt;
            this.Subgroups = subgroups;
        }

        public GroupModel(string name, string year, string studCnt, string exCnt, string labCnt, string projCnt, string maxLess)
        {
            this.Name = name;
            this.Year = int.Parse(year);
            this.StudentsCnt = int.Parse(studCnt);
            this.ProjGrCnt = int.Parse(projCnt);
            this.ExGrCnt = int.Parse(exCnt);
            this.LabGrCnt = int.Parse(labCnt);
            this.MaxLessonsPerDay = int.Parse(maxLess);
        }

        public string FullName { get
            {
                string _year;
                switch (Year)
                {
                    case 1:
                        _year = "I";
                        break;
                    case 2:
                        _year = "II";
                        break;
                    case 3:
                        _year = "III";
                        break;
                    case 4:
                        _year = "IV";
                        break;
                    case 5:
                        _year = "V";
                        break;
                    default:
                        _year = "";
                        break;
                }
                return Name + " " + _year;
            }
        }

        /// <summary>
        /// unique idenftifier for this group.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Name of group eg. Mechatronics
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Representrs year of group eg. 3
        /// </summary>
        public int Year { get; set; }

        /// <summary>
        /// Represents number of students in this group.
        /// </summary>
        public int StudentsCnt { get; set; }

        public int MaxLessonsPerDay { get; set; }

        public List<SubgroupModel> Subgroups { get; set; } = new List<SubgroupModel>();

        // Represents number of groups for group Type. 
        public int ExGrCnt { get; set; }
        public int LabGrCnt { get; set; }
        public int ProjGrCnt { get; set; }

        public void SetGroupsCnt()
        {
            ExGrCnt = (from s in Subgroups
                    where s.Type == 2
                    select s).Count();
            LabGrCnt = (from s in Subgroups
                      where s.Type == 3
                      select s).Count();
            ProjGrCnt = (from s in Subgroups
                      where s.Type == 4
                      select s).Count();
        }
    }
}
