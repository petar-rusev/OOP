using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Customer
{
    
    class Customer:ICloneable,IComparable<Customer>
    {
        private string name;
        private string middleName;
        private string lastName;
        private string id;
        private string permanentAddress;
        private string mobilePhone;
        private string email;
        private List<Payment> payments;
        private string customertype;
        

        public Customer(string name, string MiddleName, string LastName, string id,string address,string phone,string email,
            List<Payment>payments,string CustomerType)
        {
            this.Name = name;
            this.MiddleName = MiddleName;
            this.LastName = LastName;
            this.Id = id;
            this.PermanentAddress = address;
            this.MobilePhone = phone;
            this.Email = email;
            this.Payments = payments;
            this.CustomerType = CustomerType;
        }
        
        public string CustomerType
        {
            get
            {
                return this.customertype;
            }
            set
            {
                this.customertype = value;
            }
        }
        public List<Payment> Payments
        {
            get
            {
                return this.payments;
            }
            set
            {
                this.payments = value;
            }
        }
        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                string mail = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+";
                Regex reg = new Regex(mail);
                Match mat = reg.Match(value);
                if (mat.Success == false)
                {
                    throw new ArgumentException("Invalid email argument.");
                }
                else
                {
                    this.email = value;
                }
            }
        }
        public string MobilePhone
        {
            get
            {
                return this.mobilePhone;
            }
            set
            {
                string mobile = @"[0-9]{10}";
                Regex reg = new Regex(mobile);
                Match mat = reg.Match(value);
                if (mat.Success == false)
                {
                    throw new ArgumentException("Invalid phone number argument.");
                }
                else
                {
                    this.mobilePhone = value;
                }
            }
        }
        public string PermanentAddress
        {
            get
            {
                return this.permanentAddress;
            }
            set
            {
                if (value == null || value == "")
                {
                    throw new ArgumentException("Invalid permanent address argument.");
                }
                else
                {
                    this.permanentAddress = value;
                }
            }
        }
        public string Id
        {
            get
            {
                return this.id;
            }
            set
            {
                string pat = @"[0-9]{7}";
                Regex reg = new Regex(pat);
                Match mat = reg.Match(value);
                if (mat.Success == false)
                {
                    throw new ArgumentException("Invalid personal ID argument.");
                }
                else
                {
                    this.id = value;
                }
            }
        }
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                string pat = @"[A-Za-z]+";
                Regex reg = new Regex(pat);
                Match mat = reg.Match(value);
                if (mat.Success == false)
                {
                    throw new ArgumentException("Invalid name argument.");
                }
                else
                {
                    this.name = value;
                }
            }
        }
        public string MiddleName
        {
            get
            {
                return this.middleName;
            }
            set
            {
                string pat = @"[A-Za-z]+";
                Regex reg = new Regex(pat);
                Match mat = reg.Match(value);
                if (mat.Success == false)
                {
                    throw new ArgumentException("Invalid name argument.");
                }
                else
                {
                    this.middleName = value;
                }
            }
        }
        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                string pat = @"[A-Za-z]+";
                Regex reg = new Regex(pat);
                Match mat = reg.Match(value);
                if (mat.Success == false)
                {
                    throw new ArgumentException("Invalid name argument.");
                }
                else
                {
                    this.lastName = value;
                }
            }
        }
        public override bool Equals(object param)
        {
            Customer customer = param as Customer;
            if (customer == null)
            {
                return false;
            }
            if (!Object.Equals(this.Name, customer.Name)||!Object.Equals(this.MiddleName,customer.MiddleName)||Object.Equals(this.LastName,customer.LastName))
            {
                return false;
            }
            if (this.Id!=customer.Id)
            {
                return false;
            }
            return true;
        }
        public static bool operator ==(Customer customer1, Customer customer2)
        {
            return Customer.Equals(customer1, customer2);
        }
        public static bool operator !=(Customer customer1, Customer customer2)
        {
            return !(Customer.Equals(customer1, customer2));
        }
        public override int GetHashCode()
        {
            return Name.GetHashCode()^Id.GetHashCode();
        }
        public override string ToString()
        {
            return string.Format("Customer:{0} {1} {2}\nPersonal ID: {3}\nAddress: {4}\nMobile Phone: {5}\nEmail: {6}\nCustomer Type: {7}\n",
                this.Name,this.MiddleName,this.LastName,this.Id,this.PermanentAddress,this.MobilePhone,this.Email,this.CustomerType);
            
        }
        public object Clone()
        {
            return new Customer(Name,MiddleName,LastName,Id,PermanentAddress,MobilePhone,Email,Payments,CustomerType)
            {
                Name=(string)this.Name.Clone(),
                MiddleName=(string)this.MiddleName.Clone(),
                LastName=(string)this.LastName.Clone(),
                PermanentAddress=(string)this.PermanentAddress.Clone(),
                MobilePhone=(string)this.MobilePhone.Clone(),
                Payments=new List<Payment>(this.Payments),
                Id=(string)this.Id.Clone(),
                Email=(string)this.Email.Clone(),
                CustomerType=(string)this.CustomerType.Clone()
            };
        }
       

        public int CompareTo(Customer other)
        {
            string first=this.Name + this.MiddleName + this.LastName;
            string second=other.Name + other.MiddleName + other.LastName;
            if (String.Compare(first,second ) < 0)
            {
                return -1;
            }
            else if (String.Compare(this.Name + this.MiddleName + this.LastName, other.Name + other.MiddleName + other.LastName) > 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
            if(int.Parse(this.Id)>int.Parse(other.Id))
            {
                return 1;
            }
            else if (int.Parse(this.Id) < int.Parse(other.Id))
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
