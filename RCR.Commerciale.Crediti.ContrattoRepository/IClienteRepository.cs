
using RCR.Commerciale.Crediti.Dominio;
using System.Collections.Generic; 

namespace RCR.Commerciale.Crediti.ContrattoRepository
{
    public interface IClienteRepository
    {
        Cliente GetCliente(int Id);

        IEnumerable<Cliente> GetListClienti();
    }
}
