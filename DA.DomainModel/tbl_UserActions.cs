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
    
    public partial class tbl_UserActions : IEntity
    {
        public int UserActionID { get; set; }
        public int UserID { get; set; }
        public int CreatorID { get; set; }
        public int ActionID { get; set; }
        public System.DateTime ActivityDate { get; set; }
    
        public virtual tbl_Actions tbl_Actions { get; set; }
        public virtual tbl_UserData tbl_UserData { get; set; }
        public EntityState EntityState { get; set; }
    }
}
