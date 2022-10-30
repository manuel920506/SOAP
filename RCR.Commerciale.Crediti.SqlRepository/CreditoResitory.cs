using Dapper;
using RCR.Commerciale.Crediti.ContrattoRepository;
using RCR.Commerciale.Crediti.Dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace RCR.Commerciale.Crediti.SqlRepository
{
    public class CreditoResitory : ICreditoRepository
    {
        public bool EliminaCredito(string Id)
        {
            using (IDbConnection connessione = new SqlConnection(ConnessioneRepository.GetStringConessione()))
            {
                connessione.Open();
                var parametri = new DynamicParameters();
                parametri.Add("IdCredito", Id);

                var result = connessione.Execute("dbo.sp_delete_credito", param: parametri, commandType: CommandType.StoredProcedure);
                return result > 0;
            }
        }

        public Credito GetCredito(string Id)
        {
            using (IDbConnection connessione = new SqlConnection(ConnessioneRepository.GetStringConessione()))
            {
                connessione.Open();
                var parametri = new DynamicParameters();
                parametri.Add("IdCredito", Id);

                var credito = connessione.QuerySingle<Credito>("dbo.sp_get_credito", param: parametri, commandType: CommandType.StoredProcedure);
                return credito;
            }
        }

       public  IEnumerable<Credito> GetListCredito()
        {
            using (IDbConnection connessione = new SqlConnection(ConnessioneRepository.GetStringConessione()))
            {
                connessione.Open();
                var parametri = new DynamicParameters();

                var clienti = connessione.Query<Credito>("dbo.sp_get_list_crediti", param: parametri, commandType: CommandType.StoredProcedure);
                return clienti;
            }
        }

        public Credito SaveCredito(Credito credito)
        {
            using (IDbConnection connessione = new SqlConnection(ConnessioneRepository.GetStringConessione()))
            {
                connessione.Open();
                var parametri = new DynamicParameters();
             
                parametri.Add("TipoCredito", credito.TipoCredito);
                parametri.Add("IdCliente", credito.IdCliente);
                parametri.Add("Data", credito.Data);
                parametri.Add("Ammontare", credito.Ammontare);
                parametri.Add("GiornoPago", credito.GiornoPago);
                parametri.Add("TassaInteresse", credito.TassaInteresse);
                parametri.Add("Commissioni", credito.Commissioni); 
                parametri.Add("IdCredito", credito.IdCredito, DbType.Int32, ParameterDirection.Output);

                var result = connessione.ExecuteScalar("dbo.sp_save_credito", param: parametri, commandType: CommandType.StoredProcedure);
                var pIdCredito = parametri.Get<Int32>("IdCredito");

                credito.IdCredito = pIdCredito;
                return credito;
            }
        }

        public Credito  UpdateCredito(Credito credito)
        {
            using (IDbConnection connessione = new SqlConnection(ConnessioneRepository.GetStringConessione()))
            {
                connessione.Open();
                var parametri = new DynamicParameters();

                parametri.Add("IdCredito", credito.IdCredito);
                parametri.Add("TipoCredito", credito.TipoCredito);
                parametri.Add("IdCliente", credito.IdCliente);
                parametri.Add("Data", credito.Data);
                parametri.Add("Ammontare", credito.Ammontare);
                parametri.Add("GiornoPago", credito.GiornoPago);
                parametri.Add("TassaInteresse", credito.TassaInteresse);
                parametri.Add("Commissioni", credito.Commissioni);

                var result = connessione.Execute("dbo.sp_update_credito", param: parametri, commandType: CommandType.StoredProcedure);
                return result > 0 ? credito : new Credito();
            }
        }
    }
}
