using Microsoft.EntityFrameworkCore;
using OlympicInsights.Models;

namespace OlympicInsights.Data 
{
    public class OlympicContext : DbContext {
    public OlympicContext (DbContextOptions<OlympicContext> options) : base(options)
    {
    
    }
     public DbSet<Athlete> Athletes => Set<Athlete>();

    }
       

}