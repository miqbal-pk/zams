using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZAMS.Model
{
    class ProjectReprt
    {
        public string ProjectName { get; set; }
        public long AmountPaid { get; set; }
        public long AmountReceived { get; set; }
        public string OwnerName { get; set; }
    }
}
