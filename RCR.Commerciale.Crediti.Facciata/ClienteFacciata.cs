using System;
using RCR.Commerciale.Crediti.Dominio; 
using System.Collections.Generic;
using RCR.Commerciale.Crediti.SqlRepository;
using RCR.Commerciale.Crediti.ContrattoRepository;

namespace RCR.Commerciale.Crediti.Facciata
{
    public class ClienteFacciata: IDisposable
    { 
        public Cliente GetCliente(int Id)
        {
            IClienteRepository cliente = new ClienteRepository();
            return cliente.GetCliente(Id);
        }

        public IEnumerable<Cliente> GetListClienti()
        {
            IClienteRepository cliente = new ClienteRepository();
            return cliente.GetListClienti();
        } 
        void IDisposable.Dispose()
        { 
            GC.SuppressFinalize(this);
        }
    }
}
