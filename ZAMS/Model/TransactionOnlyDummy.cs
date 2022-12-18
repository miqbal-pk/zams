using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZAMS.Model
{
    class TransactionOnlyDummy
    {
        public System.DateTime Date { get; set; }
        public int RefId { get; set; }
        public string Cheque_No { get; set; }
        public string Description { get; set; }
        public string Party { get; set; }
        public string Project { get; set; }

        public string Debit { get; set; }
        public string Credit { get; set; }
        public string UserName { get; set; }
    }
}
