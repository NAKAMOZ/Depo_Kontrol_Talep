using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace depo_proje
{
    internal class sqliteconn
    {
        public SQLiteConnection conn()
        {
            SQLiteConnection conn = new SQLiteConnection(@"Data Source = depo.db");
            conn.Open();
            return conn;
        }
    }
}
