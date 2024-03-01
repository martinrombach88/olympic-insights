using Microsoft.EntityFrameworkCore;
using OlympicInsights.Models;

namespace OlympicInsights.Data 
{
    public class OlympicContext : DbContext {
        public DbSet<Athlete> Athletes => Set<Athlete>();
        
        // private IConfiguration _config;
        // public OlympicContext(IConfiguration config) {
        //     _config = config;
        // }

        /*
        - onConfiguring must be applied to a db context and must be overridden, as the base does nothing.
        */
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured) {
            optionsBuilder.UseSqlServer(Environment.GetEnvironmentVariable("OLYMPICDBCONNECTIONLOCAL"), options => options.EnableRetryOnFailure());
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Athlete>().HasKey(c => c.AthleteId);//HasNoKey();
            //
            //.ToTable("Computer", "TutorialAppSchema");
        }

        
    }
       

}