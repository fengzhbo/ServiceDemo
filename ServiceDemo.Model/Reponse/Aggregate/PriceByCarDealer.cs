using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;
using ServiceDemo.Model.Reponse.Atom;

namespace ServiceDemo.Model.Reponse.Aggregate
{
    [ProtoContract]
    public class PriceByCarDealer
    {
        [ProtoMember(1)]
        public Int32 DealerID { get; set; }

        [ProtoMember(2)]
        public Int32 CarID { get; set; }

        [ProtoMember(3)]
        public Int32 PriceID { get; set; }

        [ProtoMember(4)]
        public Car CarInfo { get; set; }

        [ProtoMember(5)]
        public Price PriceInfo { get; set; }

        [ProtoMember(6)]
        public Promotion PromotionInfo { get; set; }

    }
}
