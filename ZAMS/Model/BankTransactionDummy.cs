using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZAMS.Model
{
    class BankTransactionDummy
    {
        public System.DateTime Date { get; set; }
        public long ID { get; set; }
        public string RefId { get; set; }
        public string ChequeNumber { get; set; }
        public string Description { get; set; }
        public string BankName { get; set; }
        public string AccountNumber { get; set; }
        public string Debit { get; set; }
        public string Credit { get; set; }
        public string Balance { get; set; }

        public string UserName { get; set; }


        
        
    }
}
