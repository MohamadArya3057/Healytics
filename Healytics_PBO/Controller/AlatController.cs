using Healytics_PBO.Model;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Healytics_PBO.Controller
{
    public class AlatController : IRepository<AlatModel>
    {
        public List<AlatModel> GetAll()
        {
            List<AlatModel> list = new List<AlatModel>();
            NpgsqlConnection conn = new NpgsqlConnection("Host=localhost;Username=postgres;Password=120306;Database=Healytics;port=5432");
            conn.Open();

            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = @"SELECT id_alat, nama_alat, stock FROM alat";
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new AlatModel
                {
                    ID = reader.GetInt32(0),
                    nama_alat = reader.GetString(1),
                    stock = reader.GetInt32(2)
                });
            }
            conn.Close();
            return list;
        }

        public void Insert(AlatModel a)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Host=localhost;Username=postgres;Password=120306;Database=Healytics;port=5432");
            conn.Open();

            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = $"INSERT INTO alat(nama_alat, stock) VALUES ('{a.nama_alat}', '{a.stock}')";
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void Update(AlatModel a)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Host=localhost;Username=postgres;Password=120306;Database=Healytics;port=5432");
            conn.Open();

            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = $"UPDATE alat SET nama_alat = '{a.nama_alat}', stock = '{a.stock}' WHERE id_alat = {a.ID}";
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void Delete(int id)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Host=localhost;Username=postgres;Password=120306;Database=Healytics;port=5432");
            conn.Open();

            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = $"DELETE FROM alat WHERE id_alat = {id}";
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
