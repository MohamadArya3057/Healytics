using NEW_PROJEKAN_PBO.Model;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEW_PROJEKAN_PBO.Controller
{
    public class PasienController
    {
        private string connString = "Host=localhost;Username=postgres;Password=yourpassword;Database=yourdb";

        public List<DataPasien> GetAllPasien()
        {
            var list = new List<DataPasien>();
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                string query = "SELECT nik, nama_pasien FROM transaksi GROUP BY nik, nama_pasien";
                using (var cmd = new NpgsqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new DataPasien
                        {
                            Nik = reader.GetString(0),
                            NamaPasien = reader.GetString(1)
                        });
                    }
                }
            }
            return list;
        }
    }
}
