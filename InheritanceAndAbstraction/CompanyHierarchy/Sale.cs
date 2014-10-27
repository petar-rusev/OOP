using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHierarchy
{
    class Sale : SalesEmployee, ISales
    {
        public string product;
        public decimal price;
        public string date;
        public Sale(string product, string date, decimal price)
        {
            this.Product = product;
            this.Date = date;
            this.Price = price;
        }
        public string Product
        {
            get
            {
                return this.product;
            }
            set
            {
                if (value == "" || value == null)
                {
                    throw new ArgumentException("Invalid Product name argument.The product name can't be empty or null string.");
                }
                else
                {
                    this.product=value;
                }
            }
        }
        public decimal Price { get; set; }
        public string Date { get; set; }
        
    }
}
