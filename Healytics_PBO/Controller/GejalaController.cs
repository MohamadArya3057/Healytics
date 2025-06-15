using Healytics_PBO.Model;
using Npgsql;
using System;
using System.Collections.Generic;

namespace Healytics_PBO.Controller
{
    public class GejalaController : IRepository<GejalaModel>
    {
        public List<GejalaModel> GetAll()
        {
            List<GejalaModel> list = new List<GejalaModel>();
            NpgsqlConnection conn = new NpgsqlConnection("Host=localhost;Username=postgres;Password=120306;Database=Healytics;port=5432");
            conn.Open();

            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT id_gejala, nama_gejala FROM gejala ORDER BY id_gejala";

            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new GejalaModel
                {
                    ID = reader.GetInt32(0),
                    nama_gejala = reader.GetString(1)
                });
            }
            conn.Close();
            return list;
        }

        public void Insert(GejalaModel g)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Host=localhost;Username=postgres;Password=120306;Database=Healytics;port=5432");
            conn.Open();

            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = $"INSERT INTO gejala(nama_gejala) VALUES '{g.nama_gejala}'";
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void Update(GejalaModel g)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Host=localhost;Username=postgres;Password=120306;Database=Healytics;port=5432");
            conn.Open();

            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = $"UPDATE gejala SET nama_gejala = '{g.nama_gejala}' WHERE id_gejala = {g.ID}";
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void Delete(int id)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Host=localhost;Username=postgres;Password=120306;Database=Healytics;port=5432");
            conn.Open();

            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = $"DELETE FROM gejala WHERE id_gejala = {id}";
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}