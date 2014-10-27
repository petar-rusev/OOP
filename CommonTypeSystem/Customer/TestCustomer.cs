using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer
{
    class TestCustomer
    {
        static void Main(string[] args)
        {
            Payment first=new Payment("Keyboard",120);
            Payment second=new Payment("Mouse",100);
            Payment third=new Payment("Monitor",670);
            List<Payment>payments=new List<Payment>();
            payments.Add(first);
            payments.Add(second);
            payments.Add(third);
            Customer one = new Customer("Petar", "Rusev", "Rusev", "8701239089", "Sofia,Diana Bad,ul.Loven Park 3", "0897123852", "petar.rusev@gmail.com",payments,GetEnumDescription.GetDescription(CustomerType.Diamond,""));
            Customer four = new Customer("Ivan", "Rusev", "Rusev", "8701230987", "Sofia,Diana Bad,ul.Loven Park 3", "0897123852", "ivan.rusev@gmail.com", payments, GetEnumDescription.GetDescription(CustomerType.Gold, ""));
            Customer two = (Customer)one.Clone();
            Console.WriteLine(one.ToString());
            Console.WriteLine(two.ToString());
            foreach(Payment p in one.Payments)
            {
                Console.WriteLine(p);
            }
            foreach (Payment p in two.Payments)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine(one.CompareTo(four));
        }
    }
}
