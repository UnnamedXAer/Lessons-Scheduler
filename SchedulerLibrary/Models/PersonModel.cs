using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulerLibrary.Models
{
    /// <summary>
    /// Represents one person.
    /// </summary>
    public class PersonModel
    {
        /// <summary>
        /// The unique identifier for the person.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Represents first name of this person.
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// Represents last name of this person.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Represents an academic title/degree eg. mgr
        /// </summary>
        public string Degree { get; set; }

        /// <summary>
        /// Represents and identifier used in UR.
        /// </summary>
        public string Identifier { get; set; }

        /// <summary>
        /// degree + First name + Last name.
        /// </summary>
        public string FullName
        {
            get
            {
                return $"{ Degree } { FirstName } { LastName }";
            }
        }

        public PersonModel()
        {

        }

        public PersonModel(int id)
        {
            this.Id = id;
        }

        public PersonModel(string FfName, string lName, string degree, string identifier)
        {
            this.FirstName = FfName;
            this.LastName = lName;
            this.Degree = degree;
            this.Identifier = identifier;
        }

        public PersonModel(int id, string FfName, string lName, string degree, string identifier)
        {
            this.Id = id;
            this.FirstName = FfName;
            this.LastName = lName;
            this.Degree = degree;
            this.Identifier = identifier;
        }

    }
}
