using RCR.Commerciale.Crediti.Contratti;
using RCR.Commerciale.Crediti.Dominio;
using RCR.Commerciale.Crediti.Facciata;
using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace RCR.Commerciale.Crediti.Implementation
{
    public class CreditoService : ICreditiService
    {
        bool ICreditiService.EliminaCredito(string Id)
        {
            throw new NotImplementedException();
        }

        public Credito GetCredito(string Id)
        {
            try
            {
                using (CreditoFacciata credito = new CreditoFacciata())
                {
                    return credito.GetCredito(Id);
                }
            }
            catch (Exception ex)
            {
                throw new FaultException<Error>(new Error() { ErrorCode = "10001", Description = "Exception Administrata", Message = ex.Message });
            }
        }

        public IEnumerable<Credito> GetListCredito()
        {
            using (CreditoFacciata credito = new CreditoFacciata())
            {
                return credito.GetListCredito();
            }
        }

        public Credito SaveCredito(Credito new_credito)
        {
            using (CreditoFacciata credito = new CreditoFacciata())
            {
                return credito.SaveCredito(new_credito);
            }
        }

        public Credito UpdateCredito(Credito new_credito)
        {
            using (CreditoFacciata credito = new CreditoFacciata())
            {
                return credito.UpdateCredito(new_credito);
            }
        }
    }
}
