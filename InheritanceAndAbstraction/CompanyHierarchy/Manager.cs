using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompanyHierarchy
{
    public class Manager : Employee, IManager
    {
        public List<Employee> managerlist;
        public Manager(string ID,string NameOne,string NameTwo,List<Employee>managerlist,decimal salary,string department)
            : base(ID, NameOne, NameTwo,salary,department)
        {
            this.ManagerList = managerlist;
        }
        
        public List<Employee> ManagerList{ get; set; }
    }
}
