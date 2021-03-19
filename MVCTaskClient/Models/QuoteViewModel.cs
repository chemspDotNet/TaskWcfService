using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCTaskClient.Models
{
    public class QuoteViewModel
    {

        public int QuoteID { get; set; }

        public string QuoteName { get; set; }

        public string QuoteType { get; set; }

        public QuoteViewModel()
        {

        }

        public QuoteViewModel(int quoteID, string quoteName, string quoteType)
        {
            this.QuoteID = quoteID;
            this.QuoteName = quoteName;
            this.QuoteType = quoteType;


        }
    }
}