﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MeatDeliSaiGonEntities : DbContext
    {
        public MeatDeliSaiGonEntities()
            : base("name=MeatDeliSaiGonEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tb_Contact> tb_Contact { get; set; }
        public virtual DbSet<tb_Menu> tb_Menu { get; set; }
        public virtual DbSet<tb_News> tb_News { get; set; }
        public virtual DbSet<tb_OrderDetails> tb_OrderDetails { get; set; }
        public virtual DbSet<tb_Orders> tb_Orders { get; set; }
        public virtual DbSet<tb_Product> tb_Product { get; set; }
        public virtual DbSet<tb_ProductCatagory> tb_ProductCatagory { get; set; }
        public virtual DbSet<tb_Users> tb_Users { get; set; }
        public virtual DbSet<tb_UsersType> tb_UsersType { get; set; }
    }
}