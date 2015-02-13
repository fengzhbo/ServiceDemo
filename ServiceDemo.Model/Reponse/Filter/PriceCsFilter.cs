using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace ServiceDemo.Model.Reponse.Filter
{
    [ProtoContract]
    public class PriceCsFilter
    {
        [ProtoMember(1)]
        public Int32 PriceID { get; set; }

        [ProtoMember(2)]
        public Int32 CsID { get; set; }

        [ProtoMember(3)]
        public Int32 CarID { get; set; }

    }
}
