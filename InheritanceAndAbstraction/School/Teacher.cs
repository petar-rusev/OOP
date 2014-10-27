using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace School
{
    public class Teacher : IDetail, IPeople
    {
        private string details;
        private IList<Disciplines> disciplines;
        private string name;
        public Teacher(string name,IList<Disciplines>disciplines)
        {
            this.Name = name;
            this.Disciplines = disciplines;
        }

        public Teacher(string name,IList<Disciplines>disciplines,string details)
        {
            this.Name = name;
            this.Disciplines = disciplines;
            this.Details = details;
        }
        public IList<Disciplines> Disciplines
        {
            get
            {
                return this.disciplines;
            }
            set
            {
                this.disciplines = value;
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
                    throw new ArgumentException("Invalid Teacher details argument.");
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
                string pat = @"[A-Za-z]+";
                Regex reg = new Regex(pat);
                Match mat = reg.Match(value);
                if (mat.Success == false)
                {
                    throw new ArgumentException("Invalid Teacher name argument.");
                }
                else
                {
                    this.name = value;
                }
            }
        }
    }
}
