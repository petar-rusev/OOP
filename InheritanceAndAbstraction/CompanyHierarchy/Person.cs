namespace CompanyHierarchy
{
    using System;
    public class Person : IPerson
    {
        public string id;
        public string firstname;
        public string lastname;
        public Person(string ID, string FirstName, string LastName)
        {
            this.ID = ID;
            this.FirstName = FirstName;
            this.LastName = LastName;
        }
        public string ID
        {
            get
            {
                return this.id;
            }
            set
            {
                if (value == "" || value == null)
                {
                    throw new ArgumentException("Invalid ID argument.Please enter the person ID.");
                }
                else
                {
                    this.id=value;
                }
            }
        }
        public string FirstName
        {
            get
            {
                return this.firstname;
            }
            set
            {
                if (value == "" || value == null)
                {
                    throw new ArgumentException("Invalid FirstName argument.Please enter the person FirstName.");
                }
                else
                {
                    this.firstname=value;
                }
            }
        }
        public string LastName
        {
            get
            {
                return this.lastname;
            }
            set
            {
                if (value == "" || value == null)
                {
                    throw new ArgumentException("Invalid LastName argument.Please enter the person LastName.");
                }
                else
                {
                    this.lastname=value;
                }
            }
        }
    }
}
