using System;
using System.Collections.Generic;
using RCR.Comerciale.Crediti.Contratti;
using RCR.Comerciale.Crediti.Dominio;

namespace RCR.Comerciale.Crediti.Implementation
{
    public class ClienteService : IClienteService
    {
        Cliente IClienteService.GetCliente(string numeroDocumento)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Cliente> IClienteService.GetListClienti()
        {
            throw new NotImplementedException();
        }
    }
}
