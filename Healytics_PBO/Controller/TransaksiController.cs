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
    public class TransaksiController : IRepository<TransaksiModel>
    {
        public List<TransaksiModel> GetAll()
        {
            List<TransaksiModel> list = new List<TransaksiModel>();
            using var conn = new NpgsqlConnection("Host=localhost;Username=postgres;Password=120306;Database=Healytics;port=5432");
            conn.Open();

                var cmd = new NpgsqlCommand("SELECT t.id_transaksi, t.tanggal, t.no_register, p.nama_pasien, t.total FROM transaksi t JOIN pasien p ON t.no_register = p.no_register", conn);
            var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                list.Add(new TransaksiModel
                {
                    ID = reader.GetInt32(0),
                    tanggal = reader.GetDateTime(1),
                    id_pasien = reader.GetInt32(2),
                    nama_pasien = reader.GetString(3),
                    total = reader.GetDecimal(4)
                });
            }

            return list;
        }

        public void Insert(TransaksiModel item)
        {
            throw new NotImplementedException("Gunakan InsertReturnId untuk menyimpan transaksi dan ambil ID-nya.");
        }

        public int InsertReturnId(TransaksiModel item)
        {
            int id;
            using var conn = new NpgsqlConnection("Host=localhost;Username=postgres;Password=120306;Database=Healytics;port=5432");
            conn.Open();

            var cmd = new NpgsqlCommand($"INSERT INTO transaksi(tanggal, no_register, total) VALUES ('{item.tanggal}', {item.id_pasien}, {item.total}) RETURNING id_transaksi", conn);
            id = Convert.ToInt32(cmd.ExecuteScalar());

            return id;
        }

        public void Update(TransaksiModel item)
        {
            using var conn = new NpgsqlConnection("Host=localhost;Username=postgres;Password=120306;Database=Healytics;port=5432");
            conn.Open();

            var cmd = new NpgsqlCommand($"UPDATE transaksi SET tanggal = '{item.tanggal}', no_register = {item.id_pasien}, total = {item.total} WHERE id_transaksi = {item.ID}", conn);
            cmd.ExecuteNonQuery();
        }

        public void Delete(int id)
        {
            using var conn = new NpgsqlConnection("Host=localhost;Username=postgres;Password=120306;Database=Healytics;port=5432");
            conn.Open();

            var cmd = new NpgsqlCommand($"DELETE FROM transaksi WHERE id_transaksi = {id}", conn);
            cmd.ExecuteNonQuery();
        }
    }
}