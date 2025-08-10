using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lebenslauf.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Lebenslauf.Infra.Data.Context
{
    public class AppDbContext : DbContext
    {
        #region Constructur
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options   )
        {

        }
        #endregion
        #region DbSets
        public DbSet<ThingIDo> ThingsIDo { get; set; }
        public DbSet<CustomerFeedback> CustomerFeedbacks { get; set; }
        public DbSet<CustomerLogo> CustomerLogos { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Erfahrung> Erfahrungs { get; set; }
        public DbSet<Fahigkeit> Fahigkeits { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<PortfolioCategory> PortfolioCategories { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<Information> Informations { get; set; }


        #endregion

        #region On Model CReating
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys())) {
            relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }

            base.OnModelCreating(modelBuilder);
        }
        #endregion
    }
}
