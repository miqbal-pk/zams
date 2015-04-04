using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZAMS.Model
{
    class TransactionDummy
    {
        public int Id { get; set; }
        public long Amount { get; set; }
        public string TransactionType { get; set; }
        public string Description { get; set; }
        public string OtherDetails { get; set; }
        public System.DateTime DateTime { get; set; }
        public string PayerName { get; set; }
        public string RecipientName { get; set; }
        public string ProjectName { get; set; }
    }
}
