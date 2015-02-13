using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace ServiceDemo.Model
{
    [ProtoContract]
    public class Result<T>
    {
        [ProtoMember(1)]
        public ResultCode Status { get; set; }

        [ProtoMember(2)]
        public T Data { get; set; }
    }
}
