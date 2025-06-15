using System;
using System.Collections.Generic;
using Healytics_PBO.Model;
using Npgsql;

namespace Healytics_PBO.Controller
{
    public class DetailTransaksiController : IRepository<DetailTransaksiModel>
    {
        public List<DetailTransaksiModel> GetAll()
        {
            var list = new List<DetailTransaksiModel>();
            NpgsqlConnection conn = new NpgsqlConnection("Host=localhost;Username=postgres;Password=120306;Database=Healytics;port=5432");
            conn.Open();

            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = @"SELECT dt.id_detail_transaksi, dt.id_transaksi, dt.id_obat, o.nama_obat, dt.jumlah, o.harga, dt.catatan 
                                FROM detail_transaksi dt  JOIN obat o ON dt.id_obat = o.id_obat 
                                ORDER BY dt.id_detail_transaksi DESC";

            NpgsqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                var detail = new DetailTransaksiModel
                {
                    ID = reader.GetInt32(0),
                    id_transaksi = reader.GetInt32(1),
                    id_obat = reader.GetInt32(2),
                    nama_obat = reader.GetString(3),
                    jumlah = reader.GetInt32(4),
                    harga = reader.GetDecimal(5),
                    catatan = reader.IsDBNull(6) ? "" : reader.GetString(6)
                };
                list.Add(detail);
            }

            conn.Close();
            return list;
        }

        public void Insert(DetailTransaksiModel item)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Host=localhost;Username=postgres;Password=120306;Database=Healytics;port=5432");
            conn.Open();

            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = @"INSERT INTO detail_transaksi(id_transaksi, id_obat, jumlah, catatan) VALUES (@id_transaksi, @id_obat, @jumlah, @catatan)";

            cmd.Parameters.AddWithValue("@id_transaksi", item.id_transaksi);
            cmd.Parameters.AddWithValue("@id_obat", item.id_obat);
            cmd.Parameters.AddWithValue("@jumlah", item.jumlah);
            cmd.Parameters.AddWithValue("@catatan", item.catatan ?? "");

            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void Update(DetailTransaksiModel item)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Host=localhost;Username=postgres;Password=120306;Database=Healytics;port=5432");
            conn.Open();

            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = @"UPDATE detail_transaksi SET id_transaksi = @id_transaksi, id_obat = @id_obat, jumlah = @jumlah, catatan = @catatan WHERE id_detail_transaksi = @id";

            cmd.Parameters.AddWithValue("@id_transaksi", item.id_transaksi);
            cmd.Parameters.AddWithValue("@id_obat", item.id_obat);
            cmd.Parameters.AddWithValue("@jumlah", item.jumlah);
            cmd.Parameters.AddWithValue("@catatan", item.catatan ?? "");
            cmd.Parameters.AddWithValue("@id", item.ID);

            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void Delete(int id)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Host=localhost;Username=postgres;Password=120306;Database=Healytics;port=5432");
            conn.Open();

            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "DELETE FROM detail_transaksi WHERE id_detail_transaksi = @id";
            cmd.Parameters.AddWithValue("@id", id);

            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
