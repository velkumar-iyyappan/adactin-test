using DataAccessLayer.Interfaces;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public  class RatingRepository:GenericRepository<Rating>,IRatingRepository
    {
        public RatingRepository(RepositoryContext dbContext) : base(dbContext)
        {
            var ratings = new List<Rating>()
            {
                new Rating() { Name = "Professional", Factor = 1.0 },
                new Rating() { Name = "WhiteCollar", Factor = 1.25 },
                new Rating() { Name = "LightManual", Factor = 1.50 },
                new Rating() { Name = "HeavyManual", Factor = 1.75 }
            };

            dbContext.Ratings.AddRange(ratings);
            dbContext.SaveChanges();
        }
    }
}
