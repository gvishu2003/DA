//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DA.DomainModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_Interface : IEntity
    {
        public int InterfaceID { get; set; }
        public int TransactionSeq { get; set; }
        public int daId { get; set; }
        public int InterfaceAttrMapID { get; set; }
    
        public virtual tbl_DesignAccelerator tbl_DesignAccelerator { get; set; }
        public virtual tbl_InterfaceAttrMapping tbl_InterfaceAttrMapping { get; set; }
        public virtual tbl_Transactions tbl_Transactions { get; set; }
        public EntityState EntityState { get; set; }
    }
}