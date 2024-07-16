namespace webAPI.Models
{
    public class Team
    {
        public int id { get; set; }

        public string Name { get; set; }
        
        public int Wins { get; set; }

        public int Losses { get; set; }

        public int Points
        {
            get { return Wins * 3 + Losses; }

        }
        public int Games
        {
            get { return Wins + Losses; }

        }
    }
}