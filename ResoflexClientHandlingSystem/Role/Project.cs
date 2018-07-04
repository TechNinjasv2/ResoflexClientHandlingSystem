using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResoflexClientHandlingSystem.Role
{
    class Project
    {
        private int projectID;
        private int clientID;
        private string projectName;
        private string type;
        private DateTime firstInitDate;
        private DateTime trainingCmpltDate;
        private DateTime firstEndDate;
        private DateTime secondEndDate;
        private int noOfVisits;
        private DateTime warrantyDate;
        private string terms;
        private string supportTerms;
        private string warrantyTerms;

        public Project()
        {
        }
        
        public int ProjectID { get => projectID; set => projectID = value; }
        public int ClientID { get => clientID; set => clientID = value; }
        public string Type { get => type; set => type = value; }
        public DateTime FirstInitDate { get => firstInitDate; set => firstInitDate = value; }
        public DateTime TrainingCmpltDate { get => trainingCmpltDate; set => trainingCmpltDate = value; }
        public DateTime FirstEndDate { get => firstEndDate; set => firstEndDate = value; }
        public DateTime SecondEndDate { get => secondEndDate; set => secondEndDate = value; }
        public int NoOfVisits { get => noOfVisits; set => noOfVisits = value; }
        public DateTime WarrantyDate { get => warrantyDate; set => warrantyDate = value; }
        public string Terms { get => terms; set => terms = value; }
        public string SupportTerms { get => supportTerms; set => supportTerms = value; }
        public string WarrantyTerms { get => warrantyTerms; set => warrantyTerms = value; }
        public string ProjectName { get => projectName; set => projectName = value; }
    }
}
