
using RCR.Commerciale.Crediti.Dominio;
using System.Collections.Generic; 

namespace RCR.Commerciale.Crediti.ContrattoRepository
{
    public interface ICreditoRepository
    { 
        IEnumerable<Credito> GetListCredito();
         
        Credito GetCredito(string Id);
         
        Credito SaveCredito(Credito credito);
         
        Credito UpdateCredito(Credito credito);

        bool EliminaCredito(string Id);
    }
}
