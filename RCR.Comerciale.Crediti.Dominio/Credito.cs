using System;
using System.Runtime.Serialization;

namespace RCR.Comerciale.Crediti.Dominio 
{
    [DataContract]
    public class Credito
    {
        [DataMember]
        public int IdCredito { get; set; }

        [DataMember]
        public int TipoCredito { get; set; }


        [DataMember]
        public int IdCliente { get; set; }
  
        [DataMember]
        public DateTime Data { get; set; }
        [DataMember]
        public Decimal Ammontare { get; set; }
        [DataMember]
        public DateTime GiornoPago { get; set; }
        [DataMember]
        public Decimal TassaInteresse { get; set; }
        [DataMember]
        public Decimal Commissioni { get; set; }
    }
}
