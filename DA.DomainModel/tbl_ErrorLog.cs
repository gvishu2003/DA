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
    
    public partial class tbl_ErrorLog : IEntity
    {
        public int ErrorLogID { get; set; }
        public string StackTrace { get; set; }
        public string ErrorDescription { get; set; }
        public string ClassName { get; set; }
        public Nullable<System.DateTime> ErrorDate { get; set; }
        public EntityState EntityState { get; set; }
    }
}