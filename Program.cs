using Olympics.Data;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Olympics.Models;

namespace Olympics 
{
    internal class Program
    {
        // do you need this if you're 'in main'? you've written the old template in the new template
        //also you used the console app template so be prepared to remove this later
        static void Main(string[] args) {
            //EntityContext entityFramework = new EntityContext();
            IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();
            EntityContext entityFramework = new EntityContext(config);

            //
            Athlete steveTest = new Athlete()
            {
                gender="male",
                team="UK",
                height=183,
                weight=200,
                sportEvents=["tight rope", "cheese rolling"],
                medals=["gold", "silver"],
            };

            entityFramework.Add(steveTest);
            entityFramework.SaveChanges();
        }
    }
}