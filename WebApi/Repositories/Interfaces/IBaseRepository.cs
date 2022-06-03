using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Models.Base;

namespace WebApi.Repositories
{
    public interface IBaseRepository<T> where T:BaseModel
    {
        public List<T> GetAll();
        public T Get(Guid id);
        public T Create(T model);
        public T Update(T model);
        public void Delete(Guid id);
    }
}
