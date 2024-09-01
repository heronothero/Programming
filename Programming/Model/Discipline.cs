using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    public class Discipline
    {
        /// <summary>
        /// Private property of mark
        /// </summary>
        private int mark;

        /// <summary>
        /// A private property of date
        /// </summary>
        private int date;

        /// <summary>
        /// A public property of the name of the subject
        /// </summary>
        public string NameOfTheSubject { get; set; }

        /// <summary>
        /// A public property of professor
        /// </summary>
        public string Professor { get; set; }

        /// <summary>
        /// Checking mark's field which must be int and between 1 and 5
        /// </summary>
        public int Mark
        {
            get { return mark; }
            set
            {
                Validator.AssertValueInRange(value, 1, 5, "Mark");
                mark = value;
            }
        }

        /// <summary>
        /// Checking date's field which must be int and between 2021 and this day of the year
        /// </summary>
        public int Date
        {
            get { return date; }
            set
            {
                Validator.AssertValueInRange(value, 2021, DateTime.Now.DayOfYear, "Date");
                date = value;
            }
        }

        /// <summary>
        /// A discipline's constructor
        /// </summary>
        /// <param name="nameOfTheSubject"> The field can contain letters and numbers </param>
        /// <param name="professor"> This field can contain letters and numbers </param>
        /// <param name="mark"> The field must be int in range </param>
        /// <param name="date"> The field must be a date </param>
        public Discipline(string nameOfTheSubject, string professor, int mark, int date)
        {
            NameOfTheSubject = nameOfTheSubject;
            Professor = professor;
            Mark = mark;
            Date = date;
        }
    }
}
