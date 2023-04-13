using DataAccessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly RepositoryContext _dbContext;        
        public IOccupationRepository Occupations { get; }
        public IRatingRepository Ratings { get; }

        public UnitOfWork(RepositoryContext dbContext,
                            IOccupationRepository occupationRepository,
                            IRatingRepository ratingRepository)
        {
            _dbContext = dbContext;            
            Occupations = occupationRepository;
            Ratings = ratingRepository;
        }

        public int Save()
        {
            return _dbContext.SaveChanges();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _dbContext.Dispose();
            }
        }

    }
}
