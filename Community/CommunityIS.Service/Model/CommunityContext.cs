using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunityIS.Service.Model
{
    public class CommunityContext : DbContext
    {
        public DbSet<Person> People { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<PersonRole> PersonRoles { get; set; }
        public DbSet<Faculty> Faculties { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Community> Communities { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=MONSTER\\SQLEXPRESS;Database=CommunityIS;Trusted_Connection=True;TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            // PersonRole için composite primary key
            modelBuilder.Entity<PersonRole>()
                .HasKey(pr => new { pr.PersonId, pr.RoleId });

            // PersonRole ve Person arasındaki ilişki
            modelBuilder.Entity<PersonRole>()
                .HasOne(pr => pr.Person)
                .WithMany(p => p.PersonRoles)
                .HasForeignKey(pr => pr.PersonId)
                .OnDelete(DeleteBehavior.Cascade); // Kaskad silme aktif

            // PersonRole ve Role arasındaki ilişki
            modelBuilder.Entity<PersonRole>()
                .HasOne(pr => pr.Role)
                .WithMany(r => r.PersonRoles)
                .HasForeignKey(pr => pr.RoleId)
                .OnDelete(DeleteBehavior.Cascade); // Kaskad silme aktif

            // PersonRole ve Community arasındaki ilişki
            modelBuilder.Entity<PersonRole>()
                .HasOne(pr => pr.Community)
                .WithMany(c => c.PersonRoles)
                .HasForeignKey(pr => pr.CommunityId)
                .OnDelete(DeleteBehavior.Restrict); // Kaskad silme devre dışı
        }
    }
}
