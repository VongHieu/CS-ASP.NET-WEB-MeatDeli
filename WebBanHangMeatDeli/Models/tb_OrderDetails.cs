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
    
    public partial class tb_OrderDetails
    {
        public int Id { get; set; }
        public Nullable<int> Orders_Id { get; set; }
        public Nullable<int> Product_Id { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<int> Quantity { get; set; }
    
        public virtual tb_Orders tb_Orders { get; set; }
        public virtual tb_Product tb_Product { get; set; }
    }
}
