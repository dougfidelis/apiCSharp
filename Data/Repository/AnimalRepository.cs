using Data.Contest;
using Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class AnimalRepository : BaseRepository<Animal>
    {
        public override List<Animal> GetAll()
        {
            List<Animal> list = new List<Animal>();
            using (WarrenContest warrenContext = new WarrenContest())
            {
            list = warrenContext.Animal.ToList();
            }
            
            return list;
        }

        public override string Create(Animal entity)
        {
            using (WarrenContest warrenContext = new WarrenContest())
            {
                warrenContext.Add(entity);
                warrenContext.SaveChanges();
            }
            return base.Create(entity);
        }
    }
}
