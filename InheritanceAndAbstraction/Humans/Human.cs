using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Humans
{
    public abstract class Human
    {
        private string firstName;
        private string lastName;

        public Human(string NameOne, string NameTwo)
        {
            this.FirstName = NameOne;
            this.lastName = NameTwo;

        }
        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                if (value == "" || value == null)
                {
                    throw new ArgumentException("Invalid First name argument.");
                }
                else
                {
                    this.firstName = value;
                }
            }
        }
        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                if (value == "" || value == null)
                {
                    throw new ArgumentException("Invalid second name argument.");
                }
                else
                {
                    this.lastName = value;
                }
            }
        }
        public override string ToString()
        {
            return string.Format("name: {0} {1}", this.FirstName, this.LastName);
        }
    }
}
