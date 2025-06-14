using Healytics_PBO.Model;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Healytics_PBO.Controller
{
    public class PasienController : IRepository<PasienModel>
    {
        public List<PasienModel> GetAll()
        {
            List<PasienModel> list = new List<PasienModel>();
            NpgsqlConnection conn = new NpgsqlConnection("Host=localhost;Username=postgres;Password=120306;Database=Healytics;port=5432");
            conn.Open();

            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;

            cmd.CommandText = @"SELECT p.no_register, p.nama_pasien, p.umur, p.id_desa, d.nama_desa FROM pasien p JOIN desa d ON p.id_desa = d.id_desa";
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new PasienModel
                {
                    ID = reader.GetInt32(0),
                    nama_pasien = reader.GetString(1),
                    umur = reader.GetInt32(2),
                    id_desa = reader.GetInt32(3),
                    nama_desa = reader.GetString(4)
                });
            }
            conn.Close();
            return list;
        }

        public void Insert(PasienModel p)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Host=localhost;Username=postgres;Password=120306;Database=Healytics;port=5432");
            conn.Open();

            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;

            cmd.CommandText = $"INSERT INTO pasien(nama_pasien, umur, id_desa) VALUES ('{p.nama_pasien}', {p.umur}, {p.id_desa})";
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void Update(PasienModel p)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Host=localhost;Username=postgres;Password=120306;Database=Healytics;port=5432");
            conn.Open();

            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;

            cmd.CommandText = $"UPDATE pasien SET nama_pasien = '{p.nama_pasien}', umur = {p.umur}, id_desa = {p.id_desa} WHERE no_register = {p.ID}";
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void Delete(int id)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Host=localhost;Username=postgres;Password=120306;Database=Healytics;port=5432");
            conn.Open();

            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;

            cmd.CommandText = $"DELETE FROM pasien WHERE no_register = {id}";
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
