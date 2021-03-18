using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace TaskWcfService.Models
{
    [DataContract]
    public class Quote
    {
        [DataMember]
        public int QuoteID { get; set; }
        [DataMember]
        public string QuoteName { get; set; }
        [DataMember]
        public string QuoteType { get; set; }

        public Quote()
        {

        }

        public Quote(int quoteID, string quoteName, string quoteType )
        {
            this.QuoteID = quoteID;
            this.QuoteName = quoteName;
            this.QuoteType = quoteType;
                

        }
    }
}