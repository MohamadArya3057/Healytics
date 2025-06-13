using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Collections.Generic;
using NEW_PROJEKAN_PBO.Model;

namespace NEW_PROJEKAN_PBO.Controller
{
    namespace NEW_PROJEKAN_PBO.Controller
    {
        public class TransaksiController : BaseController, IController<TransaksiModel>
        {
            public List<TransaksiModel> GetAll()
            {
                var list = new List<TransaksiModel>();

                using (var conn = GetConnection())
                {
                    string query = @"
                    SELECT t.id_transaksi, t.tanggal_transaksi, t.nama_pasien, t.keluhan,
                           o.nama_obat, o.harga, dt.jumlah, dt.total
                    FROM transaksi t
                    JOIN detail_transaksi dt ON t.id_transaksi = dt.id_transaksi
                    JOIN obat o ON dt.id_obat = o.id_obat";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new TransaksiModel
                            {
                                Id = reader.GetInt32(0),
                                TanggalTransaksi = reader.GetDateTime(1),
                                NamaPasien = reader.GetString(2),
                                Keluhan = reader.IsDBNull(3) ? "" : reader.GetString(3),
                                NamaObat = reader.GetString(4),
                                Harga = reader.GetDecimal(5),
                                Jumlah = reader.GetInt32(6),
                                Total = reader.GetDecimal(7)
                            });
                        }
                    }
                }

                return list;
            }

            public void Update(int id, string keluhan, int jumlah, decimal total)
            {
                using (var conn = GetConnection())
                {
                    var cmd1 = new NpgsqlCommand("UPDATE transaksi SET keluhan = @keluhan WHERE id_transaksi = @id", conn);
                    cmd1.Parameters.AddWithValue("@keluhan", keluhan);
                    cmd1.Parameters.AddWithValue("@id", id);
                    cmd1.ExecuteNonQuery();

                    var cmd2 = new NpgsqlCommand("UPDATE detail_transaksi SET jumlah = @jumlah, total = @total WHERE id_transaksi = @id", conn);
                    cmd2.Parameters.AddWithValue("@jumlah", jumlah);
                    cmd2.Parameters.AddWithValue("@total", total);
                    cmd2.Parameters.AddWithValue("@id", id);
                    cmd2.ExecuteNonQuery();
                }
            }

            public void Delete(int id)
            {
                using (var conn = GetConnection())
                {
                    var cmd1 = new NpgsqlCommand("DELETE FROM detail_transaksi WHERE id_transaksi = @id", conn);
                    cmd1.Parameters.AddWithValue("@id", id);
                    cmd1.ExecuteNonQuery();

                    var cmd2 = new NpgsqlCommand("DELETE FROM transaksi WHERE id_transaksi = @id", conn);
                    cmd2.Parameters.AddWithValue("@id", id);
                    cmd2.ExecuteNonQuery();
                }
            }
        }
    }
}

