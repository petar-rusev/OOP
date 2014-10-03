using System;


namespace DefiningClasses
{
    public class Person
    {
        private string Name;
        private int Age;
        private string email;
        public int myAge
        {
            get
            {
                return this.Age;
            }
            set
            {
                if (value < 1 || value > 100)
                {
                    throw new ArgumentOutOfRangeException("Invalid Age argument: The age must in a range 1-100");
                }
                else
                {
                    this.Age = value;
                }
            }
        }
        public string myName
        {
            get
            {
                return this.Name;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Invalid argument: The name must not be empty!");
                }
                else
                {
                    this.Name = value;
                }
            }
        }
        public string myEmail
        {
            get
            {
                return this.email;
            }
            set
            {

                this.email = value;
            }
        }
        public Person(string name, int age, string Email)
        {
            this.Name = name;
            this.Age = age;
            this.email = Email;

        }
        public Person(string name, int age)
            : this(name, age, null)
        {
            this.Name = name;
            this.Age = age;
            this.email = null;
        }
        public override string ToString()
        {
            return string.Format("name: {0}, age: {1}", this.Name, this.Age) + (this.email == null ? "" : ", email: " + this.email);
        }
    }
}
