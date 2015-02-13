using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace ServiceDemo.Model.Request
{
    [ProtoContract]
    public class RequestListArgs<T> : RequestArgs<T>
    {
        [ProtoMember(1)]
        public Int32 StartNum { get; set; }

        [ProtoMember(2)]
        public Int32 EndNum { get; set; }

    }
}
