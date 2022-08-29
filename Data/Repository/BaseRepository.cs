using Data.Contest;
using Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class BaseRepository<T> : IRepository<T> where T : BaseModel
    {
        public virtual List<T> GetAll()
        {
            List<T> list = new List<T>();
            using (WarrenContest warrenContext = new WarrenContest())
            {
                list = warrenContext.Set<T>().ToList();
            }

            return list;
        }

        public virtual string Create(T entity)
        {
            using (WarrenContest warrenContext = new WarrenContest())
            {
                warrenContext.Add(entity);
                warrenContext.SaveChanges();
            }
            return "Criado";
        }
       

        public virtual string Delete(int id)
        {
            using (WarrenContest context = new WarrenContest())
            {
                context.Entry(this.GetById(id)).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
                context.SaveChanges();
            }
            return "Deleted";
        }
        

        public virtual T GetById(int id)
        {
            T model = null;
            using (WarrenContest context = new WarrenContest())
            {
                model = context.Set<T>().Find(id);
            }
            return model;
        }

        public virtual string Update(T entity)
        {
            using (WarrenContest context = new WarrenContest())
            {
                context.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                context.SaveChanges();
            }
            return "Modified";
        }
    }
}
