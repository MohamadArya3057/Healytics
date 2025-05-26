using NEW_PROJEKAN_PBO.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEW_PROJEKAN_PBO.Controller
{
    public class PasienController
    {
        private List<DataPasien> daftarPasien = new List<DataPasien>();
        private int nextId = 1;

        public List<DataPasien> GetAll()
        {
            return daftarPasien;
        }

        public void Add(DataPasien pasien)
        {
            pasien.Id = nextId++;
            daftarPasien.Add(pasien);
        }

        public void Update(int index, DataPasien pasien)
        {
            if (index >= 0 && index < daftarPasien.Count)
            {
                daftarPasien[index] = pasien;
            }
        }

        public void Delete(int index)
        {
            if (index >= 0 && index < daftarPasien.Count)
            {
                daftarPasien.RemoveAt(index);
            }
        }
    }
}
