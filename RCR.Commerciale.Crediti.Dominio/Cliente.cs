using System;
using System.Runtime.Serialization;

namespace RCR.Commerciale.Crediti.Dominio
{
    [DataContract]
    public class Cliente
    {
        [DataMember]
        public int IdCliente { get; set; }
        [DataMember]
        public string Nome { get; set; }
        [DataMember]
        public string Cognome { get; set; }
        [DataMember]
        public string TipoDocumento { get; set; }
        [DataMember]
        public string NumeroDocumento { get; set; }
        [DataMember]
        public string Sesso { get; set; }
        [DataMember]
        public DateTime DataNascita { get; set; }
        [DataMember]
        public string Indirizzo { get; set; }
        [DataMember]
        public int Cap { get; set; }
        [DataMember]
        public string StatoCivile { get; set; }
    }
}
