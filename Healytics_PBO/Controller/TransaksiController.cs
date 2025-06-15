using Healytics_PBO.Model;
using Npgsql;
using System;
using System.Collections.Generic;

namespace Healytics_PBO.Controller
{
    public class TransaksiController : IRepository<TransaksiModel>
    {
        private readonly string connectionString = "Host=localhost;Username=postgres;Password=120306;Database=Healytics;port=5432";

        public List<TransaksiModel> GetAll()
        {
            var list = new List<TransaksiModel>();
            NpgsqlConnection conn = new NpgsqlConnection("Host=localhost;Username=postgres;Password=120306;Database=Healytics;port=5432");
            conn.Open();

            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = @"SELECT t.id_transaksi, t.tanggal, t.id_riwayat, p.nama_pasien, t.total FROM transaksi t JOIN riwayat_kunjungan r ON t.id_riwayat = r.id_riwayat JOIN pasien p on r.no_register = p.no_register ORDER BY t.id_transaksi DESC";

            NpgsqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                var transaksi = new TransaksiModel
                {
                    ID = reader.GetInt32(0),
                    tanggal = reader.GetDateTime(1),
                    id_riwayat = reader.GetInt32(2),
                    nama_pasien = reader.GetString(3),
                    total = reader.GetDecimal(4)
                };
                list.Add(transaksi);
            }
            reader.Close();
            conn.Close();

            foreach (var tr in list)
            {
                tr.DetailItems = GetDetailByTransaksi(tr.ID);
            }

            return list;
        }

        public List<DetailTransaksiModel> GetDetailByTransaksi(int idTransaksi)
        {
            var list = new List<DetailTransaksiModel>();
            NpgsqlConnection conn = new NpgsqlConnection("Host=localhost;Username=postgres;Password=120306;Database=Healytics;port=5432");
            conn.Open();

            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = @"SELECT dt.id_obat, o.nama_obat, dt.jumlah, o.harga, dt.catatan FROM detail_transaksi dt JOIN obat o ON o.id_obat = dt.id_obat WHERE dt.id_transaksi = @id";
            cmd.Parameters.AddWithValue("@id", idTransaksi);

            NpgsqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new DetailTransaksiModel
                {
                    id_obat = reader.GetInt32(0),
                    nama_obat = reader.GetString(1),
                    jumlah = reader.GetInt32(2),
                    harga = reader.GetDecimal(3),
                    catatan = reader.IsDBNull(4) ? "" : reader.GetString(4)
                });
            }

            reader.Close();
            conn.Close();
            return list;
        }

        public void Insert(TransaksiModel item)
        {
            throw new NotImplementedException("Gunakan InsertReturnId untuk menyimpan transaksi dan ambil ID-nya.");
        }

        public int InsertReturnId(TransaksiModel item)
        {
            int idTransaksi;

            var conn = new NpgsqlConnection(connectionString);
            conn.Open();

            var cmd = new NpgsqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "INSERT INTO transaksi(tanggal, total, id_riwayat) VALUES (@tanggal, @total, @id_riwayat) RETURNING id_transaksi";

            cmd.Parameters.AddWithValue("@tanggal", item.tanggal);
            cmd.Parameters.AddWithValue("@total", item.total);
            cmd.Parameters.AddWithValue("@id_riwayat", item.id_riwayat);

            idTransaksi = Convert.ToInt32(cmd.ExecuteScalar());

            foreach (var d in item.DetailItems)
            {
                var detailCmd = new NpgsqlCommand("INSERT INTO detail_transaksi(id_transaksi, id_obat, jumlah, catatan) VALUES (@id_transaksi, @id_obat, @jumlah, @catatan)", conn);
                detailCmd.Parameters.AddWithValue("@id_transaksi", idTransaksi);
                detailCmd.Parameters.AddWithValue("@id_obat", d.id_obat);
                detailCmd.Parameters.AddWithValue("@jumlah", d.jumlah);
                detailCmd.Parameters.AddWithValue("@catatan", d.catatan ?? "");
                detailCmd.ExecuteNonQuery();
            }

            conn.Close();
            return idTransaksi;
        }


        public void Update(TransaksiModel item)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Host=localhost;Username=postgres;Password=120306;Database=Healytics;port=5432");
            conn.Open();

            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "UPDATE transaksi SET tanggal = @tanggal, id_riwayat = @id_riwayat, total = @total WHERE id_transaksi = @id";
            cmd.Parameters.AddWithValue("@tanggal", item.tanggal);
            cmd.Parameters.AddWithValue("@total", item.total);
            cmd.Parameters.AddWithValue("@id_riwayat", item.id_riwayat);
            cmd.Parameters.AddWithValue("@id", item.ID);
            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public void Delete(int id)
        {
            NpgsqlConnection conn = new NpgsqlConnection(connectionString);
            conn.Open();

            NpgsqlCommand deleteDetail = new NpgsqlCommand();
            deleteDetail.Connection = conn;
            deleteDetail.CommandText = "DELETE FROM detail_transaksi WHERE id_transaksi = @id";
            deleteDetail.Parameters.AddWithValue("@id", id);
            deleteDetail.ExecuteNonQuery();

            NpgsqlCommand deleteTransaksi = new NpgsqlCommand();
            deleteTransaksi.Connection = conn;
            deleteTransaksi.CommandText = "DELETE FROM transaksi WHERE id_transaksi = @id";
            deleteTransaksi.Parameters.AddWithValue("@id", id);
            deleteTransaksi.ExecuteNonQuery();

            conn.Close();
        }
    }
}
