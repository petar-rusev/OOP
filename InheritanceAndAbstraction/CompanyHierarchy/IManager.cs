﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompanyHierarchy
{
    public interface IManager
    {
        List<Employee>ManagerList { get; set; }
    }
}
