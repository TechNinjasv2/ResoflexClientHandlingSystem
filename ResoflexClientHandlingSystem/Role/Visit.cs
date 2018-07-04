using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResoflexClientHandlingSystem.Role
{
    class Visit
    {
        private int visitID;
        private int projectID;
        private string type;
        private string serviceEng;
        private DateTime fromDateTime;
        private DateTime toDateTime;
        private string vehicalDetails;
        private float mileage;

        public Visit()
        {
        }
        
        public int VisitID { get => visitID; set => visitID = value; }
        public int ProjectID { get => projectID; set => projectID = value; }
        public string Type { get => type; set => type = value; }
        public string ServiceEng { get => serviceEng; set => serviceEng = value; }
        public DateTime FromDateTime { get => fromDateTime; set => fromDateTime = value; }
        public DateTime ToDateTime { get => toDateTime; set => toDateTime = value; }
        public string VehicalDetails { get => vehicalDetails; set => vehicalDetails = value; }
        public float Mileage { get => mileage; set => mileage = value; }
    }
}
