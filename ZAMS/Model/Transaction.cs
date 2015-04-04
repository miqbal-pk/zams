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
    
    public partial class Transaction
    {
        public int Id { get; set; }
        public long Amount { get; set; }
        public string TransactionType { get; set; }
        public string Description { get; set; }
        public string OtherDetails { get; set; }
        public System.DateTime DateTime { get; set; }
        public int PayerId { get; set; }
        public int RecipientId { get; set; }
        public int ProjectId { get; set; }
    
        public virtual Party Party { get; set; }
        public virtual Party Party1 { get; set; }
        public virtual Project Project { get; set; }
    }
}
