using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZAMS.Model
{
    class ProjectDummy
    {
        public ProjectDummy()
        {
            CurrentBalance = 0;
            InitialBalance = 0;
            Credit = 0;
           
        }
        public int Id { get; set; }
        public string OwnerParty { get; set; }
        public string ProjectName { get; set; }
        public string Status { get; set; }
        
        public Nullable<System.DateTime> EstimatedStartDate { get; set; }
        public System.DateTime StartDate { get; set; }
        
        public Nullable<System.DateTime> EstimatedEndDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public long InitialBalance { get; set; }
        public long CurrentBalance { get; set; }
        public long Credit { get; set; }
    }
}
