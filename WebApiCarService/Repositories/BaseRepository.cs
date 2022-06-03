using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiCarService.Models.Base;
using WebApiCarService.Database;

namespace WebApiCarService.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseModel
    {
        private ApplicationContext Context { get; set; }
        public BaseRepository(ApplicationContext context)
        {
            Context = context;
        }

        public T Create(T model)
        {
            Context.Set<T>().Add(model);
            Context.SaveChanges();
            return model;
        }

        public void Delete(Guid id)
        {
            var toDelete = Context.Set<T>().FirstOrDefault(m => m.Id == id);
            Context.Set<T>().Remove(toDelete);
            Context.SaveChanges();
        }

        public List<T> GetAll()
        {
            return Context.Set<T>().ToList();
        }

        public T Update(T model)
        {
            var toUpdate = Context.Set<T>().FirstOrDefault(m => m.Id == model.Id);
            if (toUpdate != null)
            {
                toUpdate = model;
            }
            Context.Update(toUpdate);
            Context.SaveChanges();
            return toUpdate;
        }

        public T Get(Guid id)
        {
            return Context.Set<T>().FirstOrDefault(m => m.Id == id);
        }
    }
}
