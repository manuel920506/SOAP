using Dapper;
using RCR.Commerciale.Crediti.ContrattoRepository;
using RCR.Commerciale.Crediti.Dominio;
using System.Collections.Generic; 
using System.Data;
using System.Data.SqlClient;

namespace RCR.Commerciale.Crediti.SqlRepository
{
    public class ClienteRepository: IClienteRepository
    {
        public Cliente GetCliente(int Id) 
        {
            using (IDbConnection connessione = new SqlConnection(ConnessioneRepository.GetStringConessione()))
            {
                connessione.Open();
                var parametri = new DynamicParameters();
                parametri.Add("IdCliente", Id);

                var cliente = connessione.QuerySingle<Cliente>("dbo.sp_get_cliente", param:parametri, commandType: CommandType.StoredProcedure);
                return cliente;
            }
        }

        public IEnumerable<Cliente> GetListClienti()
        {
            using (IDbConnection connessione = new SqlConnection(ConnessioneRepository.GetStringConessione()))
            {
                connessione.Open();
                var parametri = new DynamicParameters(); 

                var clienti = connessione.Query<Cliente>("dbo.sp_get_list_clienti", param: parametri, commandType: CommandType.StoredProcedure);
                return clienti;
            }
        }
    }
}
