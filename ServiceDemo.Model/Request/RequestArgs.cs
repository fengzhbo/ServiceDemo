using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace ServiceDemo.Model.Request
{
    [ProtoContract]
    public class RequestArgs<T>
    {
        [ProtoMember(1)]
        public T RequestModel { get; set; }
    }
}
