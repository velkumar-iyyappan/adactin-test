using BusinessLayer.Interfaces;
using BusinessLayer.Models;
using DataAccessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public  class PremiumProcessor: IPremiumProcessor
    {
        public IUnitOfWork _unitOfWork;

        public PremiumProcessor(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void GetPremiumDetails(InsuredPersonDetails personDetails)
        {
            var occupationDetails = _unitOfWork.Occupations.Find(x=>x.Name == personDetails.OccupationType).First();

            var factor = _unitOfWork.Ratings.Find(x => x.Name == occupationDetails.Rating).First();
        }

        private double GetDeathPremium(double sumInsured, double ratingFactor, int Age)
        {
            return (sumInsured * ratingFactor * Age) / 1000 * 12;            
        }
    }
}
