using PersonalTrackingSystem.Entity.Abstract;
using PersonalTrackingSystem.Entity.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalTrackingSystem.Entity.Concrete
{
    public class PersonalPosition : BaseEntity
    {
        public string Department { get; set; }
        public string Job { get; set; }
        public Seniority Seniority { get; set; }
        public decimal Salary { get; set; }
        public DateTime StartDate { get; set; }
        //Navs
        public PersonalBasis PersonalBasis { get; set; }
        public int PersonalID { get; set; }
    }
}
