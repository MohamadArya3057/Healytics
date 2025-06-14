using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Healytics_PBO.Controller
{
    public interface IRepository<T>
    {
        List<T> GetAll();
        void Insert(T obj);
        void Update(T obj);
        void Delete(int id);
    }
}
