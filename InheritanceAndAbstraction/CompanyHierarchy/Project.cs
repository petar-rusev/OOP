using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHierarchy
{
    class Project: IProject
    {
        public string projectname;
        public string state;
        public string details;
        public string startdate;
        public string StartDate
        {
            get
            {
                return this.startdate;

            }
            set
            {
                this.startdate = value;
            }
        }
    }
}
