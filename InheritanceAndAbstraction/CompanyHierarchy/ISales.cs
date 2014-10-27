using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompanyHierarchy
{
    public interface ISales
    {
        string Product { get; set; }
        string Date { get; set; }
        decimal Price { get; set; }
    }
}
