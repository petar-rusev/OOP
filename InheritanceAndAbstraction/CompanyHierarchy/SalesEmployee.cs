using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompanyHierarchy
{
    public class SalesEmployee : Employee, ISalesEmployee
    {
        public List<Sale> sales;
        public SalesEmployee(string ID,string Name,string SecondName,decimal salary,string department,List<Sale>sales)
            : base(ID, Name, SecondName, salary, department)
        {
            this.Sales = sales;
        }
        public List<Sale>Sales { get; set; }
    }
}
