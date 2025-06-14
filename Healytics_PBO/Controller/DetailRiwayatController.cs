using Healytics_PBO.Model;
using Npgsql;
using System;
using System.Collections.Generic;

namespace Healytics_PBO.Controller
{
    public class DetailRiwayatController : IRepository<DetailRiwayatModel>
    {
        private readonly string connectionString = "Host=localhost;Username=postgres;Password=120306;Database=Healytics;port=5432";

        public List<DetailRiwayatModel> GetAll()
        {
            var list = new List<DetailRiwayatModel>();

            using var conn = new NpgsqlConnection(connectionString);
            conn.Open();

            string query = @"
            SELECT d.id_detail_riwayat, d.id_riwayat, d.id_gejala, d.id_obat, g.nama_gejala 
            FROM detail_riwayat d 
            JOIN gejala g ON d.id_gejala = g.id_gejala";

            using var cmd = new NpgsqlCommand(query, conn);
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                list.Add(new DetailRiwayatModel
                {
                    ID = reader.GetInt32(0),
                    id_riwayat = reader.GetInt32(1),
                    id_gejala = reader.GetInt32(2),
                    id_obat = reader.IsDBNull(3) ? (int?)null : reader.GetInt32(3),
                    nama_gejala = reader.GetString(4)
                });
            }

            return list;
        }

        public void Insert(DetailRiwayatModel d)
        {
            if (d.id_obat == null)
                throw new ArgumentException("id_obat tidak boleh null. Periksa apakah obat sudah dipilih.");

            using var conn = new NpgsqlConnection(connectionString);
            conn.Open();

            string query = @"
            INSERT INTO detail_riwayat(id_riwayat, id_gejala, id_obat)
            VALUES (@id_riwayat, @id_gejala, @id_obat)";

            using var cmd = new NpgsqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id_riwayat", d.id_riwayat);
            cmd.Parameters.AddWithValue("@id_gejala", d.id_gejala);
            cmd.Parameters.AddWithValue("@id_obat", d.id_obat.Value);

            cmd.ExecuteNonQuery();
        }

        public void Update(DetailRiwayatModel d)
        {
            if (d.id_obat == null)
                throw new ArgumentException("id_obat tidak boleh null saat update.");

            using var conn = new NpgsqlConnection(connectionString);
            conn.Open();

            string query = @"
            UPDATE detail_riwayat 
            SET id_riwayat = @id_riwayat, id_gejala = @id_gejala, id_obat = @id_obat 
            WHERE id_detail_riwayat = @id";

            using var cmd = new NpgsqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id_riwayat", d.id_riwayat);
            cmd.Parameters.AddWithValue("@id_gejala", d.id_gejala);
            cmd.Parameters.AddWithValue("@id_obat", d.id_obat.Value);
            cmd.Parameters.AddWithValue("@id", d.ID);

            cmd.ExecuteNonQuery();
        }

        public void Delete(int id)
        {
            using var conn = new NpgsqlConnection(connectionString);
            conn.Open();

            using var cmd = new NpgsqlCommand("DELETE FROM detail_riwayat WHERE id_detail_riwayat = @id", conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        }

        public List<DetailRiwayatModel> GetByRiwayat(int id_riwayat)
        {
            var list = new List<DetailRiwayatModel>();

            using var conn = new NpgsqlConnection(connectionString);
            conn.Open();

            string query = @"
            SELECT id_detail_riwayat, id_riwayat, id_gejala, id_obat 
            FROM detail_riwayat 
            WHERE id_riwayat = @id_riwayat";

            using var cmd = new NpgsqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id_riwayat", id_riwayat);

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new DetailRiwayatModel
                {
                    ID = reader.GetInt32(0),
                    id_riwayat = reader.GetInt32(1),
                    id_gejala = reader.GetInt32(2),
                    id_obat = reader.IsDBNull(3) ? (int?)null : reader.GetInt32(3)
                });
            }

            return list;
        }

        public void DeleteByRiwayat(int id_riwayat)
        {
            using var conn = new NpgsqlConnection(connectionString);
            conn.Open();

            using var cmd = new NpgsqlCommand("DELETE FROM detail_riwayat WHERE id_riwayat = @id_riwayat", conn);
            cmd.Parameters.AddWithValue("@id_riwayat", id_riwayat);
            cmd.ExecuteNonQuery();
        }
    }
}