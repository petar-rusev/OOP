using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace School
{
    public class Disciplines : IDetail
    {
        private int lectures;
        private string name;
        private string details;
        private IList<Student> students;

        public Disciplines(int lectures, string name)
        {
            this.Name = name;
            this.Lectures = lectures;
        }
        public Disciplines(int lectures, string name, string details)
        {
            this.Name = name;
            this.lectures = lectures;
            this.Details = details;
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
                    throw new ArgumentException("Invalid argument details of disciplines.The details can't be empty or null string.");
                }
                else
                {
                    this.details = value;
                }
            }
        }

        public int Lectures
        {
            get
            {
                return this.lectures;
            }
            set
            {
                if (value<=0)
                {
                    throw new ArgumentException("Invalide Lectures number argument.The number of lectures can't be less than or equal to zero.");
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
                    throw new ArgumentException("Invalid argument Disciplines name.The name can contains only alphabetical chars.");
                }
                else
                {
                    this.name = value;
                }
            }
        }
    }
}
