using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompanyHierarchy
{
    public interface IEmployee
    {
        decimal Salary { get; set; }
        string Department { get; set; }
        
    }
}
