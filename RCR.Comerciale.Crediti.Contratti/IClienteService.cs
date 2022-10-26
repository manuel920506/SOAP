using RCR.Comerciale.Crediti.Dominio;
using System.Collections.Generic;
using System.ServiceModel;

namespace RCR.Comerciale.Crediti.Contratti
{
    [ServiceContract]
    public interface IClienteService
    {
        [OperationContract]
        Cliente GetCliente(string numeroDocumento);
        [OperationContract]
        IEnumerable<Cliente> GetListClienti();
    }
}
