using RCR.Commerciale.Crediti.Contratti;
using RCR.Commerciale.Crediti.Dominio;
using System;
using System.Collections.Generic; 

namespace RCR.Commerciale.Crediti.Implementation
{
    public class CreditoService : ICreditiService
    {
        bool ICreditiService.EliminaCredito(int Id)
        {
            throw new NotImplementedException();
        }

        Credito ICreditiService.GetCredito(int Id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Credito> ICreditiService.GetListCredito()
        {
            throw new NotImplementedException();
        }

        Credito ICreditiService.SaveCredito(Credito credito)
        {
            throw new NotImplementedException();
        }

        Credito ICreditiService.UpdateCredito(Credito credito)
        {
            throw new NotImplementedException();
        }
    }
}
