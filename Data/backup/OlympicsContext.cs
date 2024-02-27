using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
// using OlympicInsights.Models;
/*
namespace OlympicInsights.Data
{
    //my class entity context OlympicContext extends DbContext, which is imported from entity framework. : = extends
    public class OlympicContext : DbContext
    {
        //My class Athlete is passed as an argument to the type DbSet,
        //so entity can make table fields from the class
        public DbSet<Athlete> Athlete {get; set;}

        //Create a field for the instance of entity framework to take a configuration file / object (?)
        private IConfiguration _config;
        public OlympicContext(IConfiguration config) {
            _config = config;
        }

        //OnConfiguring - called on instantiation instead of a constructor
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //if there isn't a config 
            if(!optionsBuilder.IsConfigured) 
            {
                //pass connection string in appsettings.json to 
                //UseSQLServer and enable repeat retries
                optionsBuilder.UseSqlServer(_config.GetConnectionString("DefaultConnection"), options=> options.EnableRetryOnFailure());
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //do I need this?
            modelBuilder.HasDefaultSchema("OlympicsSchema");
     
            modelBuilder.Entity<Athlete>().ToTable("Athlete", "");
        }

    }
}
*/