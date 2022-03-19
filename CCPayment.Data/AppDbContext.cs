using CCPayment.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace CCPayment.Data
{
    public class AppDbContext : DbContext
    {
        public const string DEFAULT_SCHEMA = "CCPayment";

        public AppDbContext()
        {

        }
        public AppDbContext(DbContextOptions connString) : base(connString)
        {

        }

        public DbSet<Bank> Banks { get; set; }
        public DbSet<Bin> Bins { get; set; }
        public DbSet<CardType> CardTypes { get; set; }
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bank>().ToTable("Banks", DEFAULT_SCHEMA);
            modelBuilder.Entity<Bin>().ToTable("Bins", DEFAULT_SCHEMA);
            modelBuilder.Entity<CardType>().ToTable("CardTypes", DEFAULT_SCHEMA);
            modelBuilder.Entity<Organization>().ToTable("Organizations", DEFAULT_SCHEMA);
            modelBuilder.Entity<Transaction>().ToTable("Transactions", DEFAULT_SCHEMA);

            modelBuilder.Entity<Transaction>().Property(x => x.Amount).HasColumnType("decimal(18,2)");

            base.OnModelCreating(modelBuilder);
        }
    }
}
