using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace None_game_Project_Mock_up
{
    public class Hold
    {
        private string holdNavn;
        private int goal;
        private int win;
        private int loss;
        private int draw;
        private int matches;
        private int playerAmount;
        private string sportType;
        private int tournWins;
        private int division;

        public Hold(string holdNavn, int goal, int win, int loss, int draw, int matches, int tournWins, string sportType, int playerAmount, int division)
        {
            this.holdNavn = holdNavn;
            this.goal = goal;
            this.win = win;
            this.loss = loss;
            this.draw = draw;
            this.matches = matches;
            this.tournWins = tournWins;
            this.sportType = sportType;
            this.playerAmount = playerAmount;
            this.division = division;
            
        }
        public Hold()
        {

        }
        public int Division
        {
            get { return division; }
            set { division = value; }
        }

        public int Draw
        {
            get { return draw; }
            set { draw = value; }
        }

        public int Goal
        {
            get { return goal; }
            set { goal = value; }
        }
        
        public string HoldNavn
        {
            get { return holdNavn; }
            set { holdNavn = value; }
        }
        
        public int Loss
        {
            get { return loss; }
            set { loss = value; }
        }

        public int Matches
        {
            get { return matches; }
            set { matches = value; }
        }

        public int PlayerAmount
        {
            get { return playerAmount; }
            set { playerAmount = value; }
        }

        public string SportType
        {
            get { return sportType; }
            set { sportType = value; }
        }

        public int TournWins
        {
            get { return tournWins; }
            set { tournWins = value; }
        }

        public int Win
        {
            get { return win; }
            set { win = value; }
        }
        
    }
}
