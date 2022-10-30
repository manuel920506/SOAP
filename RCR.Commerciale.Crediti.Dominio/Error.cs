using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace RCR.Commerciale.Crediti.Dominio
{
    [DataContract]
    public class Error
    {
        [DataMember]
        public string ErrorCode { get; set; }
        [DataMember]
        public string Message { get; set; }
        [DataMember]
        public string Description { get; set; }
    }
}
