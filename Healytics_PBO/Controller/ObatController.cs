using Healytics_PBO.Model;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Healytics_PBO.Controller
{
    public class ObatController : IRepository<ObatModel>
    {
        public List<ObatModel> GetAll()
        {
            List<ObatModel> list = new List<ObatModel>();
            NpgsqlConnection conn = new NpgsqlConnection("Host=localhost;Username=postgres;Password=120306;Database=Healytics;port=5432");
            conn.Open();

            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;

            cmd.CommandText = @"SELECT o.id_obat, o.nama_obat, o.id_kategori, k.nama_kategori, o.stock, o.harga FROM obat o JOIN kategori_obat k ON o.id_kategori = k.id_kategori";

            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new ObatModel
                {
                    ID = reader.GetInt32(0),
                    nama_obat = reader.GetString(1),
                    id_kategori = reader.GetInt32(2),
                    nama_kategori = reader.GetString(3),
                    harga = reader.GetDecimal(5),
                    stock = reader.GetInt32(4),
                });
            }

            conn.Close();
            return list;
        }
        public void Insert(ObatModel o)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Host=localhost;Username=postgres;Password=120306;Database=Healytics;port=5432");
            conn.Open();

            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = $"INSERT INTO obat(nama_obat, id_kategori, harga, stock) VALUES ('{o.nama_obat}', {o.id_kategori}, {o.harga}, {o.stock})";

            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void Update(ObatModel o)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Host=localhost;Username=postgres;Password=120306;Database=Healytics;port=5432");
            conn.Open();

            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "UPDATE obat SET nama_obat = @nama_obat, id_kategori = @id_kategori, harga = @harga, stock = @stock WHERE id_obat = @id_obat";

            cmd.Parameters.AddWithValue("@nama_obat", o.nama_obat);
            cmd.Parameters.AddWithValue("@id_kategori", o.id_kategori);
            cmd.Parameters.AddWithValue("@harga", o.harga);
            cmd.Parameters.AddWithValue("@stock", o.stock);
            cmd.Parameters.AddWithValue("@id_obat", o.ID);

            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void Delete(int id)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Host=localhost;Username=postgres;Password=120306;Database=Healytics;port=5432");
            conn.Open();

            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = $"DELETE FROM obat WHERE id_obat = {id}";

            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }

    }
