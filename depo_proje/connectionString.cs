using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace depo_proje
{
    internal class connectionString
    {
        public OleDbConnection conn()
        {
            OleDbConnection conn = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.16.0; Data Source = depo.accdb");
            conn.Open();
            return conn;
        }
    }
}
