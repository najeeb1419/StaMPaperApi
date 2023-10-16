using IzlaCRM.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using System.Net.Security;
using System.Reflection;
using Task = IzlaCRM.Entity.Entities.Task;

namespace IzlaCRM.DAL
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<BankEmployeeReceipt> bankEmployeeReceipts { get; set; }
        public DbSet<BankEmployee> bankEmployees { get; set; }
        public DbSet<LookUp> LookUps { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<Payment> Payment { get; set; }
        public DbSet<Receipt> Receipts { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Tenant> Tenants { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<RolePermission> RolePermissions { get; set; }
        public DbSet<BankEmployeeReceipt> BankEmployeeReceipts { get; set; }
        public DbSet<BankEmployeePayment> BankEmployeePayments { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Permission>()
                .HasOne(x => x.ChiledPermission)
                .WithMany()
                .HasForeignKey(g => g.ParentId).IsRequired(false);
        }

    }
}
