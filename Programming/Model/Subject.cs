using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    public class Subject
    {
        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Название дисциплины не может быть пустым");
                }
                name = value;
            }
        }
        private string lecturer;
        public string Lecturer
        {
            get { return lecturer; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Поле преподаватель не может быть пустым");
                }
                lecturer = value;
            }
        }
        private int grade;
        public int Grade
        {
            get { return grade; }
            set
            {
                if (value < 0 || value > 5)
                {
                    throw new ArgumentOutOfRangeException("Оценка должна быть в диапазоне от 0 до 5");
                }
                grade = value;
            }
        }
        public Subject()
        {
            Name = "";
            Lecturer = "";
            Grade = 0;
        }
        public Subject(string name, string lecturer, int grade, int credits)
        {
            Name = name;
            Lecturer = lecturer;
            Grade = grade;
        }
    }
}
