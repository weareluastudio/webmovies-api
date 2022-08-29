﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebMovies.Models
{
    using DelegateDecompiler;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MyWebMoviesEntities : DbContext
    {
        public MyWebMoviesEntities()
            : base("name=MyWebMoviesEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        //Remove virtual to avoid lazy loading
        //Assing Computed
        public DbSet<Comment> Comments { get; set; }
        [Computed]
        public DbSet<Country> Countries { get; set; }
        [Computed]
        public DbSet<Favorite> Favorites { get; set; }
        public DbSet<Label> Labels { get; set; }
        [Computed]
        public DbSet<Language> Languages { get; set; }
        public DbSet<Link> Links { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        [Computed]
        public DbSet<UserProfile> UserProfiles { get; set; }
    }
}