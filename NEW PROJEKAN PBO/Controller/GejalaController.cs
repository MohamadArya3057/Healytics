using NEW_PROJEKAN_PBO.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEW_PROJEKAN_PBO.controller
{
    public interface IRepository<T>
    {
        List<T> GetAll();
        void Insert(T entity);
        void Update(T entity);
        void Delete(int id);
    }
}