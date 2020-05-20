using CcamManagement.Models.EnumTable;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CcamManagement.API.Models
{
    public class CcamDbContext : DbContext
    {
        public CcamDbContext(DbContextOptions<CcamDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //TABLE DATA
            modelBuilder.Entity<TypeActe>().ToTable("TR_TypeActe");
            modelBuilder.Entity<Acte>().ToTable("TR_Acte");
            modelBuilder.Entity<CategorieActe>().ToTable("TR_CategorieActe");
            modelBuilder.Entity<SousCategorieActe>().ToTable("TR_SousCategorieActe");
            modelBuilder.Entity<Chapitre>().ToTable("TR_Chapitre");

        }

        public DbSet<TypeActe> TypeActes { get; set; }
        public DbSet<Acte> Actes { get; set; }
        public DbSet<CategorieActe> CategorieActes { get; set; }
        public DbSet<SousCategorieActe> SousCategorieActes { get; set; }
        public DbSet<Chapitre> Chapitres { get; set; }

    }
}
