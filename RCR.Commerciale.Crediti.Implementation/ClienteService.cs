using System;
using System.Collections.Generic;
using System.ServiceModel;
using RCR.Commerciale.Crediti.Contratti; 
using RCR.Commerciale.Crediti.Dominio;
using RCR.Commerciale.Crediti.Facciata;

namespace RCR.Commerciale.Crediti.Implementation
{
    public class ClienteService : IClienteService
    {
        Cliente IClienteService.GetCliente(int Id)
        {
            try
            { 
                using (ClienteFacciata cliente = new ClienteFacciata())
                {
                    return cliente.GetCliente(Id);
                }
            }
            catch (Exception ex)
            { 
                throw new FaultException<Error>(new Error() {ErrorCode = "10001", Description = "Exception Administrata", Message= ex.Message });
            }
        }

        IEnumerable<Cliente> IClienteService.GetListClienti()
        {
            using (ClienteFacciata cliente = new ClienteFacciata())
            {
                return cliente.GetListClienti();
            }
        }
    }
}
