using OlympicInsights.Models;
using Microsoft.EntityFrameworkCore;
using OlympicInsights.Data;

namespace OlympicInsights
{
    internal class Program
    {
        static void Main(string[] args) {

    OlympicContext entityFramework = new OlympicContext();
    entityFramework.Add(entityFramework);
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