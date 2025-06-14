using Healytics_PBO.Model;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Healytics_PBO.Controller
{
    public class RiwayatKunjunganController : IRepository<RiwayatKunjunganModel>
    {
        public List<RiwayatKunjunganModel> GetAll()
        {
            List<RiwayatKunjunganModel> list = new List<RiwayatKunjunganModel>();
            NpgsqlConnection conn = new NpgsqlConnection("Host=localhost;Username=postgres;Password=120306;Database=Healytics;port=5432");
            conn.Open();

            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;

            cmd.CommandText = @"SELECT r.id_riwayat, r.tanggal, r.no_register, p.nama_pasien, r.catatan FROM riwayat_kunjungan r JOIN pasien p ON r.no_register = p.no_register";
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new RiwayatKunjunganModel
                {
                    ID = reader.GetInt32(0),
                    tanggal = reader.GetDateTime(1),
                    no_register = reader.GetInt32(2),
                    nama_pasien = reader.GetString(3),
                    catatan = reader.GetString(4)
                });
            }
            conn.Close();
            return list;
        }

        public void Insert(RiwayatKunjunganModel r)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Host=localhost;Username=postgres;Password=120306;Database=Healytics;port=5432");
            conn.Open();

            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;

            cmd.CommandText = $"INSERT INTO riwayat_kunjungan(tanggal, no_register, catatan) VALUES ('{r.tanggal}', {r.no_register}, '{r.catatan}')";
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public int InsertReturnId(RiwayatKunjunganModel r)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Host=localhost;Username=postgres;Password=120306;Database=Healytics;port=5432");
            conn.Open();

            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;

            cmd.CommandText = $"INSERT INTO riwayat_kunjungan(tanggal, no_register, catatan) VALUES ('{r.tanggal}', {r.no_register}, '{r.catatan}') RETURNING id_riwayat";
            int id = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();
            return id;
        }

        public void Update(RiwayatKunjunganModel r)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Host=localhost;Username=postgres;Password=120306;Database=Healytics;port=5432");
            conn.Open();

            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;

            cmd.CommandText = $"UPDATE riwayat_kunjungan SET tanggal = '{r.tanggal}', no_register = '{r.no_register}', catatan = '{r.catatan}' WHERE id_riwayat = {r.ID}";
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void Delete(int id)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Host=localhost;Username=postgres;Password=120306;Database=Healytics;port=5432");
            conn.Open();

            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;

            cmd.CommandText = $"DELETE FROM riwayat_kunjungan WHERE id_riwayat = {id}";
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public List<RiwayatKunjunganModel> GetByPasien(int id_pasien)
        {
            List<RiwayatKunjunganModel> list = new List<RiwayatKunjunganModel>();
            NpgsqlConnection conn = new NpgsqlConnection("Host=localhost;Username=postgres;Password=120306;Database=Healytics;port=5432");
            conn.Open();

            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;

            cmd.CommandText = $"SELECT r.id_riwayat, r.tanggal, r.no_register, p.nama_pasien, r.catatan FROM riwayat_kunjungan r JOIN pasien p ON r.no_register = p.no_register WHERE r.no_register = {id_pasien}";
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new RiwayatKunjunganModel
                {
                    ID = reader.GetInt32(0),
                    tanggal = reader.GetDateTime(1),
                    no_register = reader.GetInt32(2),
                    nama_pasien = reader.GetString(3),
                    catatan = reader.GetString(4)
                });
            }
            conn.Close();
            return list;
        }
    }
}
