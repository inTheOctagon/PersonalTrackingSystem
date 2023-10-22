using PersonalTrackingSystem.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalTrackingSystem.Entity.Concrete
{
    public class PersonalBasis : BaseEntity
    {
        public int TurkishIdentificationNumber { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
        public string BirthPlace { get; set; }
        public string MothersName { get; set; }
        public string FathersName { get; set; }
        public string City { get; set; }
        public string MaritalStatus { get; set; }

        //Navs:
        public PersonalEducation PersonalEducation { get; set; }
        public PersonalFile PersonalFile { get; set; }
        public PersonalPosition PersonalPosition { get; set; }
        public ICollection<PersonalLeave> PersonalLeaves { get; set; }

    }
}
