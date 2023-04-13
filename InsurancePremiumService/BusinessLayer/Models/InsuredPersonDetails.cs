using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Models
{
    public class InsuredPersonDetails
    {
        public string Name { get; set; }
        public string Age { get; set; }
        public DateTime DateOfBirth { get; set; }

        public string OccupationType { get; set; }

        public string SumInsured { get; set; }
    }
}
