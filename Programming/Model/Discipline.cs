using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    public class Discipline
    {
        private string nameOfTheSubject;
        private string professor;
        private int mark;
        private int date;
        public string NameOfTheSubject { get; set; }
        public string Professor { get; set; }
        public int Mark
        {
            get { return mark; }
            set
            {
                Validator.AssertValueInRange(value, 1, 5, "Mark");
                mark = value;
            }
        }
        public int Date
        {
            get { return date; }
            set
            {
                Validator.AssertValueInRange(value, 2021, DateTime.Now.DayOfYear, "Date");
                date = value;
            }
        }
        public Discipline(string nameOfTheSubject, string professor, int mark, int date)
        {
            NameOfTheSubject = nameOfTheSubject;
            Professor = professor;
            Mark = mark;
            Date = date;
        }
    }
}
