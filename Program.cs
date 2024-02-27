using OlympicInsights.Models;

namespace OlympicInsights
{
    internal class Program
    {
        static void Main(string[] args) {
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