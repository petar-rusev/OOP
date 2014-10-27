using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace School
{
    public class Student : IDetail, IPeople
    {

        private string classnumber;
        private string details;
        private string name;
        private static IList<string> takenClassNumbers;
        static Student()
        {
            Student.takenClassNumbers = new List<string>();
        }
        public Student(string name,string classnumber)
        {
            this.Name = name;
            this.ClassNumber = classnumber;
        }

        public Student(string name,string classnumber,string details)
        {
            this.Name = name;
            this.ClassNumber = classnumber;
            this.Details = details;
        }

        public string ClassNumber
        {
            get
            {
                return this.classnumber;
            }
            set
            {
                string pat = @"[0-9]+";
                Regex reg = new Regex(pat);
                Match mat = reg.Match(value);
                if (mat.Success == false||takenClassNumbers.Contains(value))
                {
                    throw new ArgumentException("Invalid Student class number.");
                }
               
            }
        }

        public string Details
        {
            get
            {
                return this.details;
            }
            set
            {
                if (value == "" || value == null)
                {
                    throw new ArgumentException("Invalid student details argument.The details can't be empty or null string.");
                }
                else
                {
                    this.details = value;
                }
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value == "" || value == null)
                {
                    throw new ArgumentException("Invalid student name argument.The name of the student can't be empty or null string.");
                }
                else
                {
                    this.name = value;
                }
            }
        }
    }
}
