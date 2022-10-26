using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace RCR.Commerciale.Crediti.SqlRepository
{
    public class ConnessioneRepository
    {
        public static string GetStringConessione()
        {
            return ConfigurationManager.ConnectionStrings["CreditiDB"].ToString();
        }
    }
}
