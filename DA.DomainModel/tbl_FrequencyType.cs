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
    
    public partial class tbl_FrequencyType : IEntity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_FrequencyType()
        {
            this.tbl_ChannelAlertAttrMapping = new HashSet<tbl_ChannelAlertAttrMapping>();
        }
    
        public int FreqTypeID { get; set; }
        public string FreqTypeDesc { get; set; }
        public int daId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_ChannelAlertAttrMapping> tbl_ChannelAlertAttrMapping { get; set; }
        public virtual tbl_DesignAccelerator tbl_DesignAccelerator { get; set; }
        public EntityState EntityState { get; set; }
    }
}