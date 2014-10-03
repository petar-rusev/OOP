using System;
namespace LaptopShop.ShopClasses
{
    public class Battery
    {
        private string type;
        private int life;
        private string cell;
        private string power;

        public int currLife
        {
            get
            {
                return this.life;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid Battery Life Arrgument: The battery life can not be negative number!");
                }
                else
                {
                    this.life = value;
                }
            }
        }
        public string currType
        {
            get
            {
                return this.type;
            }
            set
            {
                if (value!=null&&string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid Battery type Arrgument: The battery type can not be empty string!");
                }
                else
                {
                    this.type = value;
                }
            }
        }
        public string currCells
        {
            get
            {
                return this.cell;
            }
            set
            {
                if (value !=null&&string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid Battery Manufacturer Arrgument.The battery manufacturer can not be empty string!");
                }
                else
                {
                    this.cell = value;
                }
            }
        }
        public string currPow
        {
            get
            {
                return this.power;
            }
            set
            {
                if (value!=null&&string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid Battery Power Arrgument.The battery power can not be less than 0!");
                }
                else
                {
                    this.power = value;
                }
            }
        }
        public Battery(string type, string cells, string pow)
        {
            this.cell = cells;
            this.type = type;
            this.power = pow;
            
        }
        public Battery(int Life):this(null,null,null)
        {
            this.life = Life;
        }
       
    }
}
