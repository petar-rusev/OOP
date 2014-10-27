using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Humans
{
    class Worker : Human
    {
        private decimal weekSalary;
        private int workHours;

        public Worker(string NameOne, string NameTwo, decimal money, int hours)
            : base(NameOne, NameTwo)
        {
            this.WeekSalary = money;
            this.WorkHours = hours;
        }
        public int WorkHours
        {
            get
            {
                return this.workHours;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid work hours argument.");
                }
                else
                {
                    this.workHours = value;
                }
            }
        }
        public decimal WeekSalary
        {
            get
            {
                return this.weekSalary;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid week salary argument.");
                }
                else
                {
                    this.weekSalary = value;
                }
            }
        }
        public decimal MoneyPerHour(Worker worker)
        {
            decimal MoneyHour = this.WorkHours / this.WeekSalary;
            return MoneyHour;
        }
    }
}
