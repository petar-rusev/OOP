using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringDisperser
{
    class StringDisperser:ICloneable,IComparable,IEnumerable
    {
        private string one;
        private string two;
        private string three;
        private string disperser;
        public StringDisperser(string one, string two, string three)
        {
            this.One = one;
            this.Two = two;
            this.Three = three;
        }
        public override bool Equals(object param)
        {
            StringDisperser disperser = param as StringDisperser;
            if (disperser == null)
            {
                return false;
            }
            if (!Object.Equals(this.One, disperser.One) || Object.Equals(this.Two, disperser.Two) || Object.Equals(this.Three, disperser.Three))
            {
                return false;
            }
            return true;
        }
        public static bool operator ==(StringDisperser first, StringDisperser second)
        {
            return StringDisperser.Equals(first, second);
        }
        public static bool operator !=(StringDisperser first, StringDisperser second)
        {
            return !(StringDisperser.Equals(first, second));
        }
        public override int GetHashCode()
        {
            return One.GetHashCode()^Two.GetHashCode()^Three.GetHashCode();
        }
        public override string ToString()
        {
             return string.Format("{0},{1},{2}",this.One,this.Two,this.Three);
        }
        public object Clone()
        {
            return new StringDisperser(One, Two, Three)
            {
                One=(string)this.One.Clone(),
                Two=(string)this.Two.Clone(),
                Three=(string)this.Three.Clone()
            };
        }
        public int CompareTo(Object param)
        {
            if (param == null)
            {
                return 1;
            }
            StringDisperser other = param as StringDisperser;
            if (other != null)
            {
                return (this.One + this.Two + this.Three).CompareTo(other.One + other.Two + other.Three);

            }
            else
            {
                throw new ArgumentException("Object is not a StringDisperser");
            }
        }
        
        public string One
        {
            get
            {
                return this.one;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid string argument.");
                }
                else
                {
                    this.one = value;
                }
            }
        }
        public string Two
        {
            get
            {
                return this.two;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid string argument.");
                }
                else
                {
                    this.two = value;
                }
            }
        }
        public string Three
        {
            get
            {
                return this.three;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid string argument.");
                }
                else
                {
                    this.three = value;
                }
            }
        }



        public IEnumerator GetEnumerator()
        {
            var text = this.ToString();
            var length = text.Length;
            for (var i = 0; i < length; i++)
            {
                yield return text[i];
            }
        }
    }
}
