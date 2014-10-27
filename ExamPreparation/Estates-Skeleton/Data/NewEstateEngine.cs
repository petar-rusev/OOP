namespace Estates.Data
{
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Estates.Engine;
using Estates.Interfaces;
    class NewEstateEngine :EstateEngine
    {
       
         public  override string ExecuteCommand(string cmdName, string[] cmdArgs)
        {
            switch (cmdName)
            {
                case "find-rents-by-location":
                    return ExecuteFindRentsByLocationCommand(cmdArgs[0]);
                case "find-rents-by-price":
                    return ExecuteFindRentsByPrice(cmdArgs[0], cmdArgs[1]);
                default: return base.ExecuteCommand(cmdName, cmdArgs);
            }
        }
        protected virtual string ExecuteFindRentsByLocationCommand(string location)
        {
            var offers=this.Offers
                .Where(of => of.Estate.Location == location && of.Type.ToString() =="Rent")
                .OrderBy(of => of.Estate.Name);
            return FormatQueryResults(offers);
         
        }
        protected virtual string ExecuteFindRentsByPrice(string min, string max)
        {
            decimal minimum = decimal.Parse(min);
            decimal maximum = decimal.Parse(max);

            
            var offers = this.Offers
                .Where(o => o is RentOffer)
                .Cast<IRentOffer>()
                .Where(o => (o.PricePerMonth > minimum) &&
                (o.PricePerMonth < maximum))
                .OrderBy(o => o.PricePerMonth)
                .ThenBy(o => o.Estate.Name)
                .ToList();
                return FormatQueryResults(offers);

        }
        
    }
}
