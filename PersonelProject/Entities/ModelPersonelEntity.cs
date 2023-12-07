using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace PersonelProject.Entities
{
    public partial class ModelPersonelEntity : DbContext
    {
        public ModelPersonelEntity()
            : base("name=ModelPersonelEntity")
        {
        }

        public virtual DbSet<Personeller> Personellers { get; set; }
        public virtual DbSet<Unit> Units { get; set; }
        public virtual DbSet<ViewPersonelUnit> ViewPersonelUnits { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Personeller>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Personeller>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<Personeller>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<Personeller>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<Personeller>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Unit>()
                .Property(e => e.UnitName)
                .IsUnicode(false);

            modelBuilder.Entity<Unit>()
                .Property(e => e.Explanation)
                .IsUnicode(false);

            modelBuilder.Entity<ViewPersonelUnit>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<ViewPersonelUnit>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<ViewPersonelUnit>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<ViewPersonelUnit>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<ViewPersonelUnit>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<ViewPersonelUnit>()
                .Property(e => e.UnitName)
                .IsUnicode(false);
        }
    }
}
