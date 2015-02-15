using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace ServiceDemo.Model.Reponse.Atom
{
    [ProtoContract]
    public class Dealer
    {
        [ProtoMember(1)]
        public Int32 DealerID { get; set; }

        [ProtoMember(2)]
        public String DealerName { get; set; }

        [ProtoMember(3)]
        public String DealerFullName { get; set; }

        [ProtoMember(4)]
        public Int32 DealerBizMode { get; set; }

        [ProtoMember(6)]
        public Int32 DealerStatus { get; set; }

        [ProtoMember(7)]
        public Int32 LocationID { get; set; }

        [ProtoMember(8)]
        public String LocationName { get; set; }

        [ProtoMember(9)]
        public Int32 CityID { get; set; }

        [ProtoMember(10)]
        public String CityName { get; set; }

        [ProtoMember(11)]
        public Int32 ProvID { get; set; }

        [ProtoMember(12)]
        public String ProvName { get; set; }

        [ProtoMember(13)]
        public String DealerSaleAddr { get; set; }

        [ProtoMember(14)]
        public Int32 SaleRegionType { get; set; }

        [ProtoMember(15)]
        public String DealerTel { get; set; }

        [ProtoMember(16)]
        public String MainBrand { get; set; }

        [ProtoMember(17)]
        public String GoogleMapLat { get; set; }

        [ProtoMember(18)]
        public String GoogleMapLng { get; set; }

    }
}
