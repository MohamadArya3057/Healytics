using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Healytics_PBO.Model
{
    public class DetailTransaksiModel : BaseModel
    {
        public int id_transaksi { get; set; }
        public int id_obat { get; set; }
        public string nama_obat { get; set; }
        public int jumlah { get; set; }
        public decimal harga { get; set; }
        public string catatan { get; set; }
    }
}
