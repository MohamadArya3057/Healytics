using Healytics_PBO.Model;
using Npgsql;
using System;
using System.Collections.Generic;

namespace Healytics_PBO.Controller
{
    public class GejalaController : IRepository<GejalaModel>
    {
        private readonly string connectionString = "Host=localhost;Username=postgres;Password=120306;Database=Healytics;port=5432";

        public List<GejalaModel> GetAll()
        {
            List<GejalaModel> list = new List<GejalaModel>();
            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT id_gejala, nama_gejala FROM gejala";

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new GejalaModel
                        {
                            ID = reader.GetInt32(0),
                            Nama_Gejala = reader.GetString(1)
                        });
                    }
                }
            }
            return list;
        }

        public void Insert(GejalaModel g)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                string query = $"INSERT INTO gejala(nama_gejala) VALUES ('{g.Nama_Gejala}')";

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Update(GejalaModel g)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                string query = $"UPDATE gejala SET nama_gejala = '{g.Nama_Gejala}' WHERE id_gejala = {g.ID}";

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Delete(int id)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                string query = $"DELETE FROM gejala WHERE id_gejala = {id}";

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
