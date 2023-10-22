using PersonalTrackingSystem.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalTrackingSystem.Entity.Concrete
{
    public class PersonalFile : BaseEntity
    {
        public string ResidenceAddress { get; set; } 
        public string HealthReportPath { get; set; }
        public string CriminalRecordPath { get; set; }
        public string DrivingLicencePath { get; set; }
        public string CorporateAgreementPath { get; set; }
        public string CVPath { get; set; }

        //Navs
        public PersonalBasis PersonalBasis { get; set; }
        public int PersonalID { get; set; }
    }
}
