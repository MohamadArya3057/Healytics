using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Healytics_PBO.Model
{
    public class TransaksiModel : BaseModel
    {
        public string nama_pasien { get; set; }
        public DateTime tanggal { get; set; }
        public decimal total { get; set; }
        public int id_riwayat { get; set; }
        public List<DetailTransaksiModel> DetailItems { get; set; } = new List<DetailTransaksiModel>();
    }
}
