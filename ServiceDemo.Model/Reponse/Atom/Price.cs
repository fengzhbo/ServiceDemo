using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace ServiceDemo.Model.Reponse.Atom
{
    [ProtoContract]
    public class Price
    {
        [ProtoMember(1)]
        public Int32 PriceID { get; set; }

        [ProtoMember(2)]
        public Int32 DealerID { get; set; }

        [ProtoMember(3)]
        public Int32 CarID { get; set; }

        [ProtoMember(4)]
        public Decimal VendorPrice { get; set; }

        [ProtoMember(5)]
        public Decimal SmsPrice { get; set; }

        [ProtoMember(6)]
        public String PromotionInfo{get;set;}

    }
}
