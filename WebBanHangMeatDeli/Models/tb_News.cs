//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebBanHangMeatDeli.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_News
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Alias { get; set; }
        public Nullable<int> Menu_Id { get; set; }
        public string Description { get; set; }
        public string Details { get; set; }
        public string Image { get; set; }
        public string CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
    
        public virtual tb_Menu tb_Menu { get; set; }
    }
}
