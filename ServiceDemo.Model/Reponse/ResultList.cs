using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace ServiceDemo.Model.Reponse
{
    [ProtoContract]
    public class ResultList<T> : Result<T>
    {
        [ProtoMember(1)]
        public Int32 AllCount { get; set; }

        [ProtoMember(2)]
        public Int32 ResultCount { get; set; }
    }
}
