using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompanyHierarchy
{
    public interface ISalesEmployee:ISales
    {
        List<Sale>Sales { get; set; }
    }
}
