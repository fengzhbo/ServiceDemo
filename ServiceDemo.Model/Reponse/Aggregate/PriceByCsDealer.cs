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
    public class PriceByCsDealer
    {
        [ProtoMember(1)]
        public Int32 DealerID { get; set; }

        [ProtoMember(2)]
        public CarSerial CsInfo  { get; set; }

        [ProtoMember(3)]
        public List<PriceByCarDealer> PriceList { get; set; }

    }
}
