using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace CompanyHierarchy
{
   
    public class Employee : Person, IEmployee
    {
        public Employee(string ID,string FirstName,string LastName,decimal salary,string department)
            : base(ID, FirstName, LastName)
        {
            this.Salary = salary;
            this.Department = department;
        }
        public decimal salary;
        public string department;
        public decimal Salary
        {
            get
            {
                return this.salary;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid Employee salary argument. The salary can be greater or equal to 0.");

                }
                else
                {
                    this.salary=value;
                }
            }
        }
        public string Department
        {
            get
            {
                return this.department;
            }
            set
            {
                if (value == "" || value == null)
                {
                    throw new ArgumentException("Invalid Employee Department argument. The department can't be empty or null string.");
                }
                else
                {
                    this.department = value;
                }
            }
        }
        
    }
}
