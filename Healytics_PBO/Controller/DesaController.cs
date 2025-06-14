using Healytics_PBO.Model;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Healytics_PBO.Controller
{
    public class DesaController : IRepository<DesaModel>
    {
        public List<DesaModel> GetAll()
        {
            List<DesaModel> list = new List<DesaModel>();
            NpgsqlConnection conn = new NpgsqlConnection("Host=localhost;Username=postgres;Password=120306;Database=Healytics;port=5432");
            conn.Open();

            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = @"SELECT id_desa, nama_desa FROM desa";
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new DesaModel
                {
                    ID = reader.GetInt32(0),
                    nama_desa = reader.GetString(1)
                });
            }
            conn.Close();
            return list;
        }

        public void Insert(DesaModel d)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Host=localhost;Username=postgres;Password=120306;Database=Healytics;port=5432");
            conn.Open();

            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = $"INSERT INTO desa(nama_desa) VALUES ('{d.nama_desa}')";
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void Update(DesaModel d)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Host=localhost;Username=postgres;Password=120306;Database=Healytics;port=5432");
            conn.Open();

            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = $"UPDATE desa SET nama_desa = '{d.nama_desa}' WHERE id = {d.ID}";
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void Delete(int id)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Host=localhost;Username=postgres;Password=120306;Database=Healytics;port=5432");
            conn.Open();

            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = $"DELETE FROM desa WHERE id_desa = {id}";
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
