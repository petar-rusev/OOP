using System;

namespace LaptopShop.ShopClasses
{
    class Devices
    {
        static void Main(string[] args)
        {
            string model="Lenovo Yoga 2 Pro";
            string manufacturer = "Lenovo";
            string processor = "Intel Core i5-4210U (2-core, 1.70 - 2.70 GHz, 3MB cache)";
            string ram = "8 GB";
            string GPU = "Intel HD Graphics 4400";
            string HDD = "128GB SSD";
            string screen = "13.3\" (33.78 cm) – 3200 x 1800 (QHD+), IPS sensor display";
            Battery battery = new Battery("Li-Ion","4-cells","2550");
            Battery lifeBat = new Battery(12);
            double price = 2220.0;

            Laptop testOne = new Laptop(model,price,processor,GPU,screen,lifeBat,battery,manufacturer,HDD,ram);
            Laptop testTwo = new Laptop(model, price);
            Console.WriteLine(testOne.ToString());
            Console.WriteLine(testTwo.ToString());
            

            
        }
    }
}
