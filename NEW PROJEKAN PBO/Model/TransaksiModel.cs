using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEW_PROJEKAN_PBO.Model
{
    public class TransaksiModel : BaseModel
    {
        public DateTime TanggalTransaksi { get; set; }
        public string NamaPasien { get; set; }
        public string Keluhan { get; set; }
        public string NamaObat { get; set; }
        public decimal Harga { get; set; }
        public int Jumlah { get; set; }
        public decimal Total { get; set; }

        public override string ToString()
        {
            return $"{NamaPasien} - {NamaObat}";
        }
    }

}
