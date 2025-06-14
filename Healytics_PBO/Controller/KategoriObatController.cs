using Healytics_PBO.Model;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Healytics_PBO.Controller
{
    public class KategoriObatController : IRepository<KategoriObatModel>
    {
        public List<KategoriObatModel> GetAll()
        {
            List<KategoriObatModel> list = new List<KategoriObatModel>();
            NpgsqlConnection conn = new NpgsqlConnection("Host=localhost;Username=postgres;Password=120306;Database=Healytics;port=5432");
            conn.Open();

            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;

            cmd.CommandText = @"SELECT id_kategori, nama_kategori FROM kategori_obat";
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new KategoriObatModel
                {
                    ID = reader.GetInt32(0),
                    nama_kategori = reader.GetString(1)
                });
            }
            conn.Close();
            return list;
        }

        public void Insert(KategoriObatModel o)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Host=localhost;Username=postgres;Password=120306;Database=Healytics;port=5432");
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = $"INSERT INTO kategori_obat(nama_kategori) VALUES ('{o.nama_kategori}')";
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void Update(KategoriObatModel o)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Host=localhost;Username=postgres;Password=120306;Database=Healytics;port=5432");
            conn.Open();

            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;

            cmd.CommandText = $"UPDATE kategori_obat SET nama_kategori = '{o.nama_kategori}' WHERE id_kategori = {o.ID}";
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void Delete(int id)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Host=localhost;Username=postgres;Password=120306;Database=Healytics;port=5432");
            conn.Open();

            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;

            cmd.CommandText = $"DELETE FROM kategori_obat WHERE id_kategori = {id}";
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
