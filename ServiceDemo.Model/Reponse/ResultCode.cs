using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace ServiceDemo.Model
{
    [ProtoContract]
    public enum ResultCode
    {
        OK=200,
        NotFound=404,
        ServiceError=500
    }
}
