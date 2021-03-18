using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using TaskWcfService.Models;


namespace TaskWcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        

      public  List<Quote> GetQuotes()
        {
            var quotes = new List<Quote>()
            {
                new Quote {QuoteID= 1, QuoteName="Auto Insurance Quote", QuoteType="Monthly" },

                new Quote {QuoteID= 2, QuoteName="Health Insurance Quote", QuoteType="Monthly" },

                new Quote {QuoteID= 3, QuoteName="Life Insurance Quote", QuoteType="Monthly" },
            };
            return quotes;
        }

       
    }
}
