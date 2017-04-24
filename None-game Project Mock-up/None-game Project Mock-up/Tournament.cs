using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace None_game_Project_Mock_up
{
    public class Tournament
    {
        private string tournamentName;
        private string startDate;
        private string endDate;
        private string teamAmount;
        private string sportType;
        private int tournamentType;

        public string TournamentName
        {
            get{return tournamentName;}
            set{tournamentName = value;}
        }

        public string StartDate
        {
            get{return startDate;}
            set{startDate = value;}
        }

        public string EndDate
        {
            get{return endDate;}
            set{endDate = value;}
        }

        public string TeamAmount
        {
            get{return teamAmount;}
            set{teamAmount = value;}
        }

        public string SportType
        {
            get{return sportType;}
            set{sportType = value;}
        }

        public int TournamentType
        {
            get{return tournamentType;}
            set{tournamentType = value;}
        }

        public Tournament(string tournamentName, string startDate, string endDate, string teamAmount, string sportType, int tournamentType)
        {
            this.TournamentName = tournamentName;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.TeamAmount = teamAmount;
            this.SportType = sportType;
            this.TournamentType = tournamentType;
        }
        public Tournament()
        {

        }
    }
}
