using Healytics_PBO.Model;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Healytics_PBO.Controller
{
    public class DetailRiwayatController : IRepository<DetailRiwayatModel>
    {
        public List<DetailRiwayatModel> GetAll()
        {
            List<DetailRiwayatModel> list = new List<DetailRiwayatModel>();
            NpgsqlConnection conn = new NpgsqlConnection("Host=localhost;Username=postgres;Password=120306;Database=Healytics;port=5432");
            conn.Open();

            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;

            cmd.CommandText = @"SELECT d.id_detail_riwayat, d.id_riwayat, d.id_gejala, g.nama_gejala FROM detail_riwayat d JOIN gejala g ON d.id_gejala = g.id_gejala";
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new DetailRiwayatModel
                {
                    ID = reader.GetInt32(0),
                    id_riwayat = reader.GetInt32(1),
                    id_gejala = reader.GetInt32(2),
                    nama_gejala = reader.GetString(3)
                });
            }
            conn.Close();
            return list;
        }

        public void Insert(DetailRiwayatModel d)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Host=localhost;Username=postgres;Password=120306;Database=Healytics;port=5432");
            conn.Open();

            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;

            cmd.CommandText = $"INSERT INTO detail_riwayat(id_riwayat, id_gejala) VALUES ({d.id_riwayat}, {d.id_gejala})";
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void Update(DetailRiwayatModel d)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Host=localhost;Username=postgres;Password=120306;Database=Healytics;port=5432");
            conn.Open();

            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;

            cmd.CommandText = $"UPDATE detail_riwayat SET id_riwayat = {d.id_riwayat}, id_gejala = {d.id_gejala} WHERE id = {d.ID}";
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void Delete(int id)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Host=localhost;Username=postgres;Password=120306;Database=Healytics;port=5432");
            conn.Open();

            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;

            cmd.CommandText = $"DELETE FROM detail_riwayat WHERE id_detail_riwayat = {id}";
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public List<DetailRiwayatModel> GetByRiwayat(int id_riwayat)
        {
            List<DetailRiwayatModel> list = new List<DetailRiwayatModel>();
            NpgsqlConnection conn = new NpgsqlConnection("Host=localhost;Username=postgres;Password=120306;Database=Healytics;port=5432");
            conn.Open();

            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;

            cmd.CommandText = $"SELECT id_detail_riwayat, id_riwayat, id_gejala FROM detail_riwayat WHERE id_riwayat = {id_riwayat}";
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new DetailRiwayatModel
                {
                    ID = reader.GetInt32(0),
                    id_riwayat = reader.GetInt32(1),
                    id_gejala = reader.GetInt32(2)
                });
            }
            conn.Close();
            return list;
        }

        public void DeleteByRiwayat(int id_riwayat)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Host=localhost;Username=postgres;Password=120306;Database=Healytics;port=5432");
            conn.Open();

            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;

            cmd.CommandText = $"DELETE FROM detail_riwayat WHERE id_riwayat = {id_riwayat}";
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
