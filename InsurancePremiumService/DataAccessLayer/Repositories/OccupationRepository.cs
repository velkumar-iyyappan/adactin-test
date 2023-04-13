using DataAccessLayer.Interfaces;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public  class OccupationRepository: GenericRepository<Occupation>, IOccupationRepository
    {
        public OccupationRepository(RepositoryContext dbContext) : base(dbContext)
        {

            var occupations = new List<Occupation>()
            {
                new Occupation(){Id=1, Name ="Cleaner", Rating="LightManual"},
                new Occupation(){Id=2, Name ="Doctor", Rating="Professional"},
                new Occupation(){Id=3, Name ="Author", Rating="WhiteCollar"},
                new Occupation(){Id=4, Name ="Farmer", Rating="HeavyManual"},
                new Occupation(){Id=5, Name ="Mechanic", Rating="HeavyManual"},
                new Occupation(){Id=6, Name ="Florist", Rating="LightManual"}

            };

            dbContext.Occupations.AddRange(occupations);
            dbContext.SaveChanges();
        }
    }
}
