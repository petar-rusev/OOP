using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Humans
{
    class Student : Human
    {
        private string facultyNumber;

        public Student(string one,string two,string number)
            : base(one, two)
        {
            this.FacultyNumber = number;
        }

        public string FacultyNumber
        {
            get
            {
                return this.facultyNumber;
            }
            set
            {
                string pat = @"[0-9]+";
                Regex reg = new Regex(pat);
                Match mat = reg.Match(value);
                if (value.Length < 5 || value.Length > 10 || mat.Success == false)
                {
                    throw new ArgumentException("Invalid Faculty number argument.");
                }
                else
                {
                    this.facultyNumber = value;
                }
            }
        }
        public override string ToString()
        {
            return string.Format("First name: {0}\nSecond name: {1}Faculty Number: {2}",this.FirstName,this.LastName,this.FacultyNumber);
        }
    }
}
