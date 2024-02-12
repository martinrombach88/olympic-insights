namespace Olympics.Models{
    public class Athlete
    {
        //the primary key is the athlete id
        public int AthleteId { get; set;}
        public string gender {get; set;}
        public string team {get; set;}
        public int height { get; set;}
        public int weight { get; set;}
        public string[] sportEvents {get; set;}
        public string[] medals {get; set;}

        public Athlete()
        {
            // if (VideoCard == null)
            // {
            //     VideoCard = "";
            // }
            // if (Motherboard == null)
            // {
            //     Motherboard = "";
            // }
            // if (CPUCores == null)
            // {
            //     CPUCores = 0;
            // }
        }
    }
}