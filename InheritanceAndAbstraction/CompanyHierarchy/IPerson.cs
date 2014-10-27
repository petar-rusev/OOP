using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompanyHierarchy
{
    public interface IPerson
    {
        string ID { get; set; }

        string FirstName { get; set; }
        string LastName { get; set; }
        
    }
}
