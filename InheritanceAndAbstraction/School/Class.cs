using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace School
{
    public class Class : IDetail
    {
        
        private IList<Teacher>teachers;
        private IList<Student>students;
        private string details;
        public Class(IList<Teacher>teachers,IList<Student>students)
        {
            this.Teachers = teachers;
            this.Students = students;
        }
        public Class(IList<Teacher>teachers,IList<Student>students,string details)
        {
            this.Teachers = teachers;
            this.Students = students;
            this.Details = details;
        }
        public IList<Teacher>Teachers
        {
            get
            {
                return this.teachers;
            }
            set
            {
                this.teachers = value;
            }
        }
        public IList<Student> Students
        {
            get
            {
                return this.students;
            }
            set
            {
                this.students = value;
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
                if (value==""||value==null)
                {
                    throw new ArgumentException("Invalid class Details.The details can't be empty or null string.");
                }
                else
                {
                    this.details = value;
                }
            }
        }
    }
}
