//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Project_TPA_AN.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class PurchaseRequest
    {
        public int PurchaseID { get; set; }
        public int DepartmentID { get; set; }
        public string PurchaseDescription { get; set; }
        public System.DateTime PurchaseRequestedDate { get; set; }
        public string PurchaseStatus { get; set; }
    
        public virtual Department Department { get; set; }
    }
}
