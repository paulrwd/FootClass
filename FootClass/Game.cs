using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootClass
{
    public class Game
    {
        public string GameDate { get; set; }
        public string HomeClub { get; set; }
        public string AwayClub { get; set; }
        public int HomeGoals { get; set; }
        public int AwayGoals { get; set; }

        public Game(string gameDate, string homeClub, string awayClub)
        {
            GameDate = gameDate;
            HomeClub = homeClub;
            AwayClub = awayClub;


        }

        public string PrintHeader(string home, string away,string city)
        {
            
            return $"{GameDate} состоится матч {home} : {away} в городе {city}";
        }
    }
}
