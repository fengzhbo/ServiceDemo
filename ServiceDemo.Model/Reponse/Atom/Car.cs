using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace ServiceDemo.Model.Reponse.Atom
{
    [ProtoContract]
    public class Car
    {
        [ProtoMember(1)]
        public Int32 CarID { get; set; }

        [ProtoMember(2)]
        public Int32 CsID { get; set; }

        [ProtoMember(3)]
        public String CarName { get; set; }

        [ProtoMember(4)]
        public Int32 CarYear { get; set; }

        [ProtoMember(5)]
        public Decimal CarAdvicePrice { get; set; }

        [ProtoMember(6)]
        public String CarSaleState { get; set; }

        [ProtoMember(7)]
        public float CarExhaust { get; set; }

        [ProtoMember(8)]
        public String CarGearBox { get; set; }

    }
}
