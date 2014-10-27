using Estates.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Estates
{
    public class SaleOffer : Offer,ISaleOffer
    {
        private decimal price;
        public SaleOffer(OfferType type, IEstate estate,decimal price):base(OfferType.Sale,estate)
        {
            this.Price = price;
        }
        public SaleOffer(OfferType type):base(OfferType.Sale)
        {

        }
        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                this.price = value;
            }
        }
        
        public override string ToString()
        {
            return base.ToString() + string.Format("Price: {0}", this.Price);
        }
    }
}
