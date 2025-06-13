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

                string query = "SELECT no_register, nama_pasien, umur, id_desa FROM pasien";

                using (var cmd = new NpgsqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new DataPasien
                        {
                            NoRegister = reader.GetString(0),
                            NamaPasien = reader.GetString(1),
                            Umur = reader.GetInt32(2),
                            IdDesa = reader.GetInt32(3)
                        });
                    }
                }
            }
            return list;
        }
    }
}
