//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ZAMS.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class BankTransaction
    {
        public long Id { get; set; }
        public string Description { get; set; }
        public long Amount { get; set; }
        public long Balance { get; set; }
        public long AllBankBalance { get; set; }
        public string OtherDetail { get; set; }
        public string TransactionType { get; set; }
        public int BankId { get; set; }
        public System.DateTime TransactionDate { get; set; }
        public string RefID { get; set; }
        public string UserName { get; set; }
    
        public virtual Bank Bank { get; set; }
    }
}