using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulerLibrary.Models
{
    public class SubjectModel
    {
        /// <summary>
        /// Represents unique id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Represents a name of subject.
        /// </summary>
        public string Name { get; set; }

        public string CellColor { get; set; }

        public string FullName {
            get
            {
                /*string _type;
                switch (this.Type)
                {
                    case 1:
                        _type = "Wykład";
                        break;
                    case 2:
                        _type = "Ćwiczenia";
                        break;
                    case 3:
                        _type = "Laboratorium";
                        break;
                    case 4:
                        _type = "Projekt";
                        break;
                    default: _type = "?";
                        break;
                }*/
                return $"{ Name } - { TypeName }";
            }
        }

        public string TypeName
        {
            get
            {
                string _type;
                switch (this.Type)
                {
                    case 1:
                        _type = "Wykład";
                        break;
                    case 2:
                        _type = "Ćwiczenia";
                        break;
                    case 3:
                        _type = "Laboratorium";
                        break;
                    case 4:
                        _type = "Projekt";
                        break;
                    default:
                        _type = "?";
                        break;
                }
                return _type;
            }
        }

        /// <summary>
        /// Represents type of Lesson
        /// 1 - lecture
        /// 2 - exercises
        /// 3 - laboratory
        /// 4 - project
        /// </summary>
        public int Type { get; set; } 

        /// <summary>
        /// Represents number of hours for this subject.
        /// </summary>
        public int HoursInSemesterCnt { get; set; }

        public int TeacherId { get; set; } = -1;

        public SubjectModel(string name, int type, string hCnt )
        {
            this.Name = name;
            this.Type = type;
            this.HoursInSemesterCnt = int.Parse(hCnt);
        }

        public SubjectModel(int id, string name, int type, int hCnt, string cColor, int perId = -1)
        {
            this.Id = id;
            this.Name = name;
            this.Type = type;
            this.HoursInSemesterCnt = hCnt;
            this.TeacherId = perId;
            this.CellColor = cColor;
        }

        public SubjectModel(int id, string name, int type)
        {
            this.Id = id;
            this.Name = name;
            this.Type = type;
        }

        public SubjectModel()
        {

        }
    }
}
