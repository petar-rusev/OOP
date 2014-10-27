using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer
{
    class Payment:ICloneable
    {
        private string productName;
        private decimal price;

        public Payment(string name, decimal price)
        {
            this.ProductName = name;
            this.Price = price;
        }
        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value<0)
                {
                    throw new ArgumentException("Invalid product type argument.");
                }
                else
                {
                    this.price = value;
                }
            }
        }
        public string ProductName
        {
            get
            {
                return this.productName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid product name argument.");
                }
                else
                {
                    this.productName = value;
                }
            }
        }
        public override string ToString()
        {
            return string.Format("Product Name: {0} Price: {1}", this.ProductName, this.Price);
        }
        public object Clone()
        {
            return new Payment(ProductName, Price)
            {
                ProductName=this.ProductName,
                Price=this.Price
            };
        }
    }
}
