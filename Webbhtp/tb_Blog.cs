//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Webbhtp
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_Blog
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_Blog()
        {
            this.tb_Comment = new HashSet<tb_Comment>();
        }
    
        public int BlogId { get; set; }
        public string Image { get; set; }
        public string CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string Description { get; set; }
        public string Detail { get; set; }
        public bool IsActive { get; set; }
        public string content { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_Comment> tb_Comment { get; set; }
    }
}
