using Core;
using Entity;
using Entity.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorys.DBContext
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext(DbContextOptions<ApiDbContext> options) :
            base(options)
        {

        }

        public ApiDbContext()
        {

        }
        public DbSet<Category> Categorys { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Globals.connection_string_name);
        }

        public override int SaveChanges()
        {
            try
            {
                Audit();
                return base.SaveChanges();
            }
            catch (Exception e)
            {

                throw;
            }
           
        }

        public async Task<int> SaveChangesAsync()
        {
            Audit();
            return await base.SaveChangesAsync();
        }

        private void Audit()
        {
            var entries = ChangeTracker.Entries().Where(x => x.Entity is Base && (x.State == EntityState.Added || x.State == EntityState.Modified));
            foreach (var entry in entries)
            {
                if (entry.State == EntityState.Added)
                {
                    ((Base)entry.Entity).Created = DateTime.UtcNow;
                }
            ((Base)entry.Entity).Modified = DateTime.UtcNow;
            }
        }
    }
}
