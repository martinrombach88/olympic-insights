namespace Olympics.Models{
    public class Athlete
    {
        //the primary key is the computer id
        public int AthleteId { get; set;}
        
        public int height { get; set;}

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