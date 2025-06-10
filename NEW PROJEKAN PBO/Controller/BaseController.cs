using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEW_PROJEKAN_PBO.Controller
{
    public abstract class BaseController
    {
        protected readonly string connString = "Host=localhost;Username=postgres;Password=sayaarya16;Database=Healytics";

        protected NpgsqlConnection GetConnection()
        {
            var conn = new NpgsqlConnection(connString);
            conn.Open();
            return conn;
        }
    }
}