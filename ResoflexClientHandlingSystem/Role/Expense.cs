using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResoflexClientHandlingSystem.Role
{
    class Expense
    {
        private int expID;
        private int visitID;
        private string category;
        private string billNo;
        private decimal expense;

        public Expense()
        {
        }
        
        public int ExpID { get => expID; set => expID = value; }
        public int VisitID { get => visitID; set => visitID = value; }
        public string Category { get => category; set => category = value; }
        public string BillNo { get => billNo; set => billNo = value; }
        public decimal Exp { get => expense; set => expense = value; }
    }
}
