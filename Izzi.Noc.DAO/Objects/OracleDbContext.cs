using System;
using System.Data.Entity;
using Izzi.Noc.Entities.DataStructure;

namespace Izzi.Noc.DAO.Objects
{
    public class OracleDbContext : DbContext
    {
        public DbSet<Template> Templates { get; set; }
        protected override void OnModelCreating(DbModelBuilder
        modelBuilder)
        {
            modelBuilder.HasDefaultSchema("HR");
        }
        internal object GetEntityKey<T>(T entity) where T : class
        {
            throw new NotImplementedException();
        }
    }
}