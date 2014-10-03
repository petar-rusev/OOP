using System;

namespace LaptopShop.ShopClasses
{
    public class Laptop
    {
        private string model;
        private string man;
        private string process;
        private string ram;
        private string gpu;
        private string hdd;
        private string screen;
        private Battery batteryLife;
        private Battery battery;
        private double lapPrice;

        public string currModel
        {
            get
            {
                return this.model;
            }
            set
            {
                if (value != null&&string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid Laptop model Arrgument.The model can not be an empty string!");
                }
                else
                {
                    this.model = value;
                }
            }
        }
        public string manufact
        {
            get
            {
                return this.man;
            }
            set
            {
                if (value != null&&string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid Laptop manufacturer Arrgument.The manufacturer can not be an empty string!");
                }
                else
                {
                    this.man = value;
                }
            }
        }
        public string processor
        {
            get
            {
                return this.process;
            }
            set
            {
                if (value != null&&string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid Laptop processor Arrgument.The processor can not be an empty string!");
                }
                else
                {
                    this.process = value;
                }
            }
        }
        public string Ram
        {
            get
            {
                return this.ram;
            }
            set
            {
                if (value!=null&&string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid Laptop RAM Arrgument.The RAM must be a number!Example 1,1.5,2,etc.");
                }
                else
                {
                    this.ram = value;
                }
            }
        }
        public string graphics
        {
            get
            {
                return this.gpu;
            }
            set
            {
                if (value != null&&string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid GPU Arrgument.The GPU can not be empty string!");
                }
                else
                {
                    this.gpu = value;
                }
            }
        }
        public string HDD
        {
            get
            {
                return this.hdd;
            }
            set
            {
                if (value!=null&&string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid HDD Arrgument.The HDD can not be less than 0!");
                }
                else
                {
                    this.hdd = value;
                }
            }
        }
        public string scr
        {
            get
            {
                return this.screen;
            }
            set
            {
                if (value !=null&&string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid screen Arrgument.The screen can not be empty string!");
                }
                else
                {
                    this.screen = value;
                }
            }
        }
        public double price
        {
            get
            {
                return this.lapPrice;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid screen Arrgument.The screen can not be empty string!");
                }
                else
                {
                    this.lapPrice = value;
                }
            }
        }

        public Laptop(string model=null,double Price=0, string processor=null, string gpu=null, string screen=null, Battery life=null, Battery Battery=null,string manufacturer=null,string hdd=null,string ram=null)
        {
            this.currModel = model;
            this.manufact = manufacturer;
            this.processor = processor;
            this.graphics = gpu;
            this.scr = screen;
            this.battery=Battery;
            this.batteryLife = life;
            this.price = Price;
            this.HDD = hdd;
            this.Ram = ram;
            
        }
        public Laptop(string model, double Price)
            : this(model,Price,null,null,null,null,null,null,null,null)
        {
            this.currModel = model;
            this.price = Price;
        }
        public override string ToString()
        {
            if (this.manufact == null && this.processor == null && this.Ram == null && this.graphics == null && this.HDD == null && this.screen == null && this.battery == null && this.batteryLife == null)
            {
                return string.Format("model: {0}\nprice: {1}\n",this.model,this.price);
            }
            else
            {
                return string.Format("model: {0}\nmanufacturer: {1}\nprocessor: {2}\nRAM: {3}\ngraphics card: {4}\nHDD: {5}\nscreen: {6}\nbattery: {7}\nbattery life: {8}\nprice: {9}\n", this.currModel, this.manufact, this.processor, this.Ram, this.graphics, this.HDD, this.scr, battery.currType + ", " + battery.currCells + ", " + battery.currPow + " mAh", this.batteryLife.currLife.ToString() + " h", this.price + "lv.");
            }
        }
                                                                                                                                                                                            
    }
}
