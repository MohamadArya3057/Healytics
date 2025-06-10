using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEW_PROJEKAN_PBO.Controller
{
    public interface IController<T>
    {
        List<T> GetAll();
        void Update(int id, string keluhan, int jumlah, decimal total);
        void Delete(int id);
    }
}
