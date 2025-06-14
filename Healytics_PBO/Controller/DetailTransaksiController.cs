using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Healytics_PBO.Controller;
using Healytics_PBO.Model;
using Npgsql;

namespace Healytics_PBO.Controller
{
    public class DetailTransaksiController : IRepository<DetailTransaksiModel>
    {
        public List<DetailTransaksiModel> GetAll()
        {
            throw new NotImplementedException("Gunakan GetByTransaksi untuk mengambil berdasarkan ID transaksi.");
        }
        public List<DetailTransaksiModel> GetByTransaksi(int idTransaksi)
        {
            List<DetailTransaksiModel> list = new List<DetailTransaksiModel>();
            using var conn = new NpgsqlConnection("Host=localhost;Username=postgres;Password=120306;Database=Healytics;port=5432");
            conn.Open();

            var cmd = new NpgsqlCommand(@"
            SELECT d.id_detail_transaksi, d.id_transaksi, d.id_obat, o.nama_obat, d.jumlah, o.harga, d.catatan
            FROM detail_transaksi d
            JOIN obat o ON d.id_obat = o.id_obat
            WHERE d.id_transaksi = @id", conn);
            cmd.Parameters.AddWithValue("@id", idTransaksi);

            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new DetailTransaksiModel
                {
                    ID = reader.GetInt32(0),
                    id_transaksi = reader.GetInt32(1),
                    id_obat = reader.GetInt32(2),
                    nama_obat = reader.GetString(3),
                    jumlah = reader.GetInt32(4),
                    harga = reader.GetDecimal(5),
                    catatan = reader.GetString(6)
                });
            }

            return list;
        }

        public void Insert(DetailTransaksiModel item)
        {
            using var conn = new NpgsqlConnection("Host=localhost;Username=postgres;Password=120306;Database=Healytics;port=5432");
            conn.Open();

            var cmd = new NpgsqlCommand($"INSERT INTO detail_transaksi(id_transaksi, id_obat, jumlah, catatan) VALUES ({item.id_transaksi}, {item.id_obat}, {item.jumlah}, '{item.catatan}')", conn);
            cmd.ExecuteNonQuery();
        }

        public void Update(DetailTransaksiModel item)
        {
            using var conn = new NpgsqlConnection("Host=localhost;Username=postgres;Password=120306;Database=Healytics;port=5432");
            conn.Open();

            var cmd = new NpgsqlCommand($"UPDATE detail_transaksi SET id_obat = {item.id_obat}, jumlah = {item.jumlah}, catatan = '{item.catatan}' WHERE id_detail_transaksi = {item.ID}", conn);
            cmd.ExecuteNonQuery();
        }

        public void Delete(int id)
        {
            using var conn = new NpgsqlConnection("Host=localhost;Username=postgres;Password=120306;Database=Healytics;port=5432");
            conn.Open();

            var cmd = new NpgsqlCommand($"DELETE FROM detail_transaksi WHERE id_detail_transaksi = {id}", conn);
            cmd.ExecuteNonQuery();
        }
    }
}