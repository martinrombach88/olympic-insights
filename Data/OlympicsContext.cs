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

        /*
        onConfiguring must be applied to a db context and must be overridden, as the base does nothing.
        
        */
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured) {
            optionsBuilder.UseSqlServer(_config.GetConnectionString("EnvKeys:OlympicDbConnect"), options=> options.EnableRetryOnFailure());
            }
        }

        // protected override void OnModelCreating(ModelBuilder modelBuilder)
        // {
        //     //keys should be defined here?
        // }

        
    }
       

}