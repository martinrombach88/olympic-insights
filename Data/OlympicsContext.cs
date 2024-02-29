using Microsoft.EntityFrameworkCore;
using OlympicInsights.Models;

namespace OlympicInsights.Data 
{
    public class OlympicContext : DbContext {
        public DbSet<Athlete> Athletes => Set<Athlete>();
        private IConfiguration _config;
        public OlympicContext(IConfiguration config) {
            _config = config;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured) {
            optionsBuilder.UseSqlServer(_config.GetConnectionString("DefaultConnection"), options=> options.EnableRetryOnFailure());
            }
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //keys should be defined here?
        }


    }
       

}