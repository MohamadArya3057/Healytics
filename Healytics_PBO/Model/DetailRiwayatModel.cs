using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Healytics_PBO.Model
{
    public class DetailRiwayatModel : BaseModel
    {
        public int id_riwayat { get; set; }
        public int? id_obat { get; set; }
        public int id_gejala { get; set; }
        public string nama_gejala { get; set; }
    }
}
