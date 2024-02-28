using OlympicInsights.Models;
using Microsoft.EntityFrameworkCore;

namespace OlympicInsights
{
    internal class Program
    {
        static void Main(string[] args) {

        //app updated to web app to make this line work
        var builder = WebApplication.CreateBuilder(args);

        //do we have controllers yet?
        builder.Services.AddControllers();
        builder.Services.AddEndpointsApiExplorer();

        //this line doesn't work because?
        //builder.Services.AddSwaggerGen();
            Athlete steve = new Athlete()
            {
                name="Steve",
                gender="male",
                team="UK",
                height=183,
                weight=200,
                sportEvents=["tight rope", "cheese rolling"],
                medals=["gold", "silver"],
            };

        }
    }
}