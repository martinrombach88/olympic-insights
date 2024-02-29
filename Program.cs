using OlympicInsights.Models;
using Microsoft.EntityFrameworkCore;
using OlympicInsights.Data;

namespace OlympicInsights
{
    internal class Program
    {
        static void Main(string[] args) {

        IConfiguration config = new ConfigurationBuilder()
        .AddJsonFile("appsettings.json")
        .Build();

        //app updated to web app to make this line work (see csproj sdk, consider web app template)
        var builder = WebApplication.CreateBuilder(args);
        //class of web application in docs: https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.builder.webapplication?view=aspnetcore-8.0

        //methods of the services property of the web application class
        //https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.builder.webapplicationbuilder.services?view=aspnetcore-8.0#microsoft-aspnetcore-builder-webapplicationbuilder-services
        builder.Services.AddControllers();
        builder.Services.AddEndpointsApiExplorer();

        //install swashbuckle to enable this
        builder.Services.AddSwaggerGen();

        //what can you do here?
        //set up an environment variable with the connection string
        builder.Services.AddSqlServer<OlympicContext>(Environment.GetEnvironmentVariable("EnvKeys:OlympicDbConnect"));
        

        
        //builder.Services.AddScoped<OlympicInsights>();

        // Athlete steve = new Athlete()
        // {
        //     name="Steve",
        //     gender="male",
        //     team="UK",
        //     height=183,
        //     weight=200,
        //     sportEvents=["tight rope", "cheese rolling"],
        //     medals=["gold", "silver"],
        // };

        }
    }
}