using Estates.Engine;
using Estates.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
namespace Estates.Data
{
    public class EstateFactory
    {
        
       
        public static IEstateEngine CreateEstateEngine()
        {
            return new NewEstateEngine();
        }
        
        public static IEstate CreateEstate(EstateType type)
        {
            
            string textType = type.ToString();
            switch (textType)
            {
                case "Apartment": return new Apartment(type);
                   
                case "Office": return new Office(type);
                    
                case "House": return new House(type);
                    
                case "Garage": return new Garage(type);
                    
                default: return new House(type);

            }
            
        }

        public static IOffer CreateOffer(OfferType type)
        {
            switch (type)
            {
                case OfferType.Sale: return new SaleOffer(type);
                case OfferType.Rent: return new RentOffer(type);
                default: return new SaleOffer(type);
            }
        }
    }
}
