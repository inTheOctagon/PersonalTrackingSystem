using PersonalTrackingSystem.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalTrackingSystem.Entity.Concrete
{
    public class PersonalLeave : BaseEntity
    {
        public DateTime LeaveDate { get; set; }
        public string Description { get; set; }

        //Navs
        public PersonalBasis PersonalBasis { get; set; }
        public int PersonalID { get; set; }
    }
}
