using Estates.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Estates
{
    public class RentOffer : Offer,IRentOffer
    {
        private decimal pricePerMonth;
         public RentOffer(OfferType type, IEstate estate,decimal Price):base(OfferType.Rent,estate)
         {
             this.PricePerMonth = Price;
         }

         public RentOffer(OfferType type):base(OfferType.Rent)
         {

         }
        public decimal PricePerMonth
        {
            get
            {
                return this.pricePerMonth;
            }
            set
            {
                this.pricePerMonth = value;
            }
        }
        public override string ToString()
        {
            return base.ToString()+string.Format("Price: {0}",this.PricePerMonth);
        }
    }
}
