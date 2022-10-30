using System;
using RCR.Commerciale.Crediti.Dominio; 
using System.Collections.Generic;
using RCR.Commerciale.Crediti.SqlRepository;
using RCR.Commerciale.Crediti.ContrattoRepository;

namespace RCR.Commerciale.Crediti.Facciata
{
    public class CreditoFacciata : IDisposable
    {  
        public Credito GetCredito(string Id)
        {
            ICreditoRepository credito = new CreditoResitory();
            return credito.GetCredito(Id);
        }

        public IEnumerable<Credito> GetListCredito()
        {
            ICreditoRepository credito = new CreditoResitory();
            return credito.GetListCredito();
        }

        public Credito SaveCredito(Credito new_credito)
        {
            ICreditoRepository credito = new CreditoResitory();
            return credito.SaveCredito(new_credito);
        }

        public Credito UpdateCredito(Credito new_credito)
        {
            ICreditoRepository credito = new CreditoResitory();
            return credito.UpdateCredito(new_credito);
        }

        public bool EliminaCredito(string Id)
        {
            ICreditoRepository credito = new CreditoResitory();
            return credito.EliminaCredito(Id);
        }

        void IDisposable.Dispose()
        { 
            GC.SuppressFinalize(this);
        }
    }
}
