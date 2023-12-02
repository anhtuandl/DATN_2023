//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BTL_TTCMWeb.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_user
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_user()
        {
            this.tbl_cart = new HashSet<tbl_cart>();
            this.tbl_Order = new HashSet<tbl_Order>();
        }
    
        public int user_id { get; set; }
        public string user_name { get; set; }
        public string user_email { get; set; }
        public string user_phone { get; set; }
        public string user_address { get; set; }
        public string user_password { get; set; }
        public Nullable<System.DateTime> CreatedAt { get; set; }
        public bool isActive { get; set; }
        public Nullable<System.DateTime> time { get; set; }
        public Nullable<int> question_id { get; set; }
        public string answer { get; set; }
        public string remember_me_identify { get; set; }
        public string remember_me_token { get; set; }
        public string avatar_img { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_cart> tbl_cart { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_Order> tbl_Order { get; set; }
        public virtual tbl_question tbl_question { get; set; }
    }
}