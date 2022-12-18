using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZAMS.Model
{
    class PtyCashDummy
    {
        public System.DateTime Date { get; set; }
        public long ID { get; set; }

        public string RefId { get; set; }
        public string Description { get; set; }
        public String Debit { get; set; }
        public String Credit { get; set; }
        public String Balance { get; set; }

        public String UserName { get; set; }
 
        
    }
}
