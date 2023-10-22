using PersonalTrackingSystem.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalTrackingSystem.Entity.Concrete
{
    public class PersonalEducation : BaseEntity
    {
        public string InstitutionName { get; set; }
        public string EducationType { get; set; }
        public string CertificatePath { get; set; }
        public PersonalBasis PersonalBasis { get; set; }
        public int PersonalID { get; set; }
    }
}
