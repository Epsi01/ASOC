//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASOC.Domain
{
    using System;
    using System.Collections.Generic;
    
    public partial class STATUS_REASON
    {
        public decimal ID { get; set; }
        public decimal ID_CURRENT { get; set; }
        public string REASON { get; set; }
        public Nullable<decimal> COSTS { get; set; }
    
        public virtual CURRENT_STATUS CURRENT_STATUS { get; set; }
    }
}
