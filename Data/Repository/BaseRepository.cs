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
            return "Deletado";
        }

        

        public virtual T GetById(int id)
        {
            T entity = null;
            return entity;
        }

        public virtual string Update(T entity)
        {
            return "Alterado";
        }
    }
}
