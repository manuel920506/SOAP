using RCR.Commerciale.Crediti.Dominio;
using System.Collections.Generic;
using System.ServiceModel;

namespace RCR.Commerciale.Crediti.Contratti
{
    [ServiceContract]
    public interface IClienteService
    {
        [OperationContract]
        [FaultContract(typeof(Error))]
        Cliente GetCliente(int Id);
        [OperationContract]
        IEnumerable<Cliente> GetListClienti();
    }
}
