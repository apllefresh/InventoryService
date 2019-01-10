using Microsoft.EntityFrameworkCore;
using DataAccess.Contract.Models;
using Microsoft.Extensions.Configuration;


namespace DataAccess.EF
{
    public class DataAccessContext : DbContext
    {
        private readonly string _connectionString;

        public DataAccessContext(string connectionString)
        {
            _connectionString = connectionString;
        }

        public DbSet<Body> bodies { get; set; }
        public DbSet<Data> datas { get; set; }
        public DbSet<Head> heads { get; set; }
        public DbSet<Result> results { get; set; }
        public DbSet<Warehouse> warehouses{ get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }
    }
}

