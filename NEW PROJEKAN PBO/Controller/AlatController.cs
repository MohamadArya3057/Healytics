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
                var cmd = new NpgsqlCommand("SELECT * FROM alat ORDER BY id", conn);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new DaftarAlat
                    {
                        Id = reader.GetInt32(0),
                        Nama = reader.GetString(1),
                        Stock = reader.GetInt32(2)
                    });
                }
            }
            return list;
        }

        public void Add(DaftarAlat daftaralat)
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                var cmd = new NpgsqlCommand("INSERT INTO alat (nama, stock) VALUES (@nama, @stock)", conn);
                cmd.Parameters.AddWithValue("@nama", daftaralat.Nama);
                cmd.Parameters.AddWithValue("@jumlah", daftaralat.Stock);
                cmd.ExecuteNonQuery();
            }
        }

        public void Update(DaftarAlat daftaralat)
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                var cmd = new NpgsqlCommand("UPDATE alat SET nama=@nama, stock=@stock WHERE id=@id", conn);
                cmd.Parameters.AddWithValue("@id", daftaralat.Id);
                cmd.Parameters.AddWithValue("@nama", daftaralat.Nama);
                cmd.Parameters.AddWithValue("@jumlah", daftaralat.Stock);
                cmd.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                var cmd = new NpgsqlCommand("DELETE FROM alat WHERE id=@id", conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
