using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Healytics_PBO.Model
{
    public class PasienModel : BaseModel
    {
        public string nama_pasien { get; set; }
        public int umur { get; set; }
        public int id_desa { get; set; }
        public string nama_desa { get; set; }
    }
}
