using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace ServiceDemo.Model.Reponse.Atom
{
    [ProtoContract]
    public class CarSerial
    {
        [ProtoMember(1)]
        public Int32 CsID { get; set; }

        [ProtoMember(2)]
        public String CsName { get; set; }

        [ProtoMember(3)]
        public Int32 BBrandID { get; set; }

        [ProtoMember(4)]
        public Int32 MBrandID { get; set; }

    }
}
