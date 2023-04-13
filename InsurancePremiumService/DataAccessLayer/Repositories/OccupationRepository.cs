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
                new Occupation(){ Name ="Cleaner", Rating="LightManual"},
                new Occupation(){ Name ="Doctor", Rating="Professional"},
                new Occupation(){ Name ="Author", Rating="WhiteCollar"},
                new Occupation(){ Name ="Farmer", Rating="HeavyManual"},
                new Occupation(){ Name ="Mechanic", Rating="HeavyManual"},
                new Occupation(){ Name ="Florist", Rating="LightManual"}

            };

            dbContext.Occupations.AddRange(occupations);
            dbContext.SaveChanges();
        }
    }
}
