using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZAMS.Model
{
    class PartyReport
    {

        public string PartyName { get; set; }
        public string PartyOwner { get; set; }

        

        public long AmountPaid { get; set; }
        public long AmountReceived { get; set; }
        public long Balance { get; set; }
    }
}
