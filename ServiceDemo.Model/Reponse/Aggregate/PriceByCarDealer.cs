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
        public Car CarInfo { get; set; }

        [ProtoMember(2)]
        public Price PriceInfo { get; set; }

        [ProtoMember(3)]
        public Promotion PromotionInfo { get; set; }

    }
}
