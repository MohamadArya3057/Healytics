using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NEW_PROJEKAN_PBO.Model;

namespace NEW_PROJEKAN_PBO.Controller
{
    public class AlatController
    {
        private string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=sayaarya16;Database=Healytics;";
        public List<DaftarAlat> GetAll()
        {
            var list = new List<DaftarAlat>();

            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                var cmd = new NpgsqlCommand("SELECT id_alat, nama_alat, stock FROM alat ORDER BY id_alat", conn);
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new DaftarAlat
                    {
                        Id_alat = reader.GetInt32(0),
                        Nama_alat = reader.GetString(1),
                        Stock = reader.GetInt32(2)
                    });
                }
            }
            return list;
        }

        public void Add(DaftarAlat alat)
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                var cmd = new NpgsqlCommand("INSERT INTO alat (nama_alat, stock) VALUES (@nama, @stock)", conn);
                cmd.Parameters.AddWithValue("@nama", alat.Nama_alat);
                cmd.Parameters.AddWithValue("@stock", alat.Stock);
                cmd.ExecuteNonQuery();
            }
        }

        public void Update(DaftarAlat alat)
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                var cmd = new NpgsqlCommand("UPDATE alat SET nama_alat=@nama, stock=@stock WHERE id_alat=@id", conn);
                cmd.Parameters.AddWithValue("@id", alat.Id_alat);
                cmd.Parameters.AddWithValue("@nama", alat.Nama_alat);
                cmd.Parameters.AddWithValue("@stock", alat.Stock);
                cmd.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                var cmd = new NpgsqlCommand("DELETE FROM alat WHERE id_alat = @id", conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
