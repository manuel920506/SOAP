using System;
using System.Collections.Generic;
using RCR.Commerciale.Crediti.Contratti; 
using RCR.Commerciale.Crediti.Dominio;
using RCR.Commerciale.Crediti.Facciata;

namespace RCR.Commerciale.Crediti.Implementation
{
    public class ClienteService : IClienteService
    {
        Cliente IClienteService.GetCliente(int Id)
        {
            using (ClienteFacciata cliente = new ClienteFacciata()) 
            {
                return cliente.GetCliente(Id);
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
