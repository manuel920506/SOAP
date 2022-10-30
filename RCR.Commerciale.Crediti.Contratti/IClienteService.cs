using RCR.Commerciale.Crediti.Dominio;
using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace RCR.Commerciale.Crediti.Contratti
{
    [ServiceContract]
    public interface IClienteService
    {
        [OperationContract]
        [WebGet(RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/GetCliente/{Id}", BodyStyle = WebMessageBodyStyle.Bare)]
        [FaultContract(typeof(Error))]
        Cliente GetCliente(int Id);
        [OperationContract]
        [WebGet(RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/GetListClienti", BodyStyle = WebMessageBodyStyle.Bare)]
        IEnumerable<Cliente> GetListClienti();
    }
}
