using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMIC225017.DataAccessNetCore.DataObject;
using Microsoft.EntityFrameworkCore;

namespace IMIC225017.DataAccessNetCore.DbContext
{
    public class IMIC072250DbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public IMIC072250DbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(Microsoft.EntityFrameworkCore.ModelBuilder modelBuilder)
        {
            // Configure your entities here
            base.OnModelCreating(modelBuilder);
        }
        // Define DbSet properties for your entities
        public DbSet<Product> product { get; set; }
    }
}
