using CRMDev.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CRMDev.Infraestructure.Persistance
{
    public class CRMDevDbContext:DbContext
    {
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Opportunity> Opportunities { get; set; }
        public DbSet<FieldWork> WorkFields { get; set; }
        public DbSet<Note> Notes { get; set; }

        public CRMDevDbContext(DbContextOptions<CRMDevDbContext> options):base(options) {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        }
    }
}
