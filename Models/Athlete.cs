namespace OlympicInsights.Models{
    public class Athlete
    {
        //ef convention -> if a field has id in it, it is a key. It'll use
        //the first it finds.
        public int AthleteId { get; set;}
        public string Name {get; set; } = "";
        public string Gender {get; set;} = "";
        public string Team {get; set;} = "";
        public int Height { get; set;}
        public int Weight { get; set;}
        public string[] SportEvents {get; set;} = [];
        
        //medals is nullable 
        public string?[] Medals {get; set;} = []; 

       
    }
}