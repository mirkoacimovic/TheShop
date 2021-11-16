using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheShop.DAL.Repositories.Intefaces
{
    public interface IBaseRepository<T> where T : class
    {
        Task Get(int id);
        Task Add(T item);
        Task Update(T item);
        Task Delete(int id);
        Task Delete(T item);
    }
}
