using RCR.Commerciale.Crediti.Dominio;
using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace RCR.Commerciale.Crediti.Contratti
{
    [ServiceContract]
    public interface ICreditiService
    {
        [OperationContract]
        [WebGet(RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/GetListCredito", BodyStyle = WebMessageBodyStyle.Bare)]
        IEnumerable<Credito> GetListCredito();

        [OperationContract] 
        [WebGet(RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/GetCredito/{Id}", BodyStyle = WebMessageBodyStyle.Bare)]
        [FaultContract(typeof(Error))]
        Credito GetCredito(string Id);

        [OperationContract]
        [WebInvoke(RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "POST", UriTemplate = "/SaveCredito", BodyStyle = WebMessageBodyStyle.Bare)]
        Credito SaveCredito(Credito credito);

        [OperationContract]
        [WebInvoke(RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "PUT", UriTemplate = "/UpdateCredito", BodyStyle = WebMessageBodyStyle.Bare)]
        Credito UpdateCredito(Credito credito);

        [OperationContract]
        [WebInvoke(RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "DELETE", UriTemplate = "/EliminaCredito/{Id}", BodyStyle = WebMessageBodyStyle.Bare)]
        bool EliminaCredito(string Id);
    }
}
