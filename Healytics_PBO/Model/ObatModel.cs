using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Healytics_PBO.Model
{
    public class ObatModel : BaseModel
    {
        public string nama_obat { get; set; }
        public int id_kategori { get; set; }
        public string nama_kategori { get; set; }
        public int stock { get; set; }
        public decimal harga { get; set; }
    }
}
