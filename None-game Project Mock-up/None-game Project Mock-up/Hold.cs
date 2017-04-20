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
        private string goal;
        private string win;
        private string loss;
        private string draw;
        private string matches;
        private string playerAmount;
        private string sportType;
        private string tournWins;
        private string division;

        public Hold(string holdNavn, string goal, string win, string loss, string draw, string matches, string tournWins, string playerAmount, string division)
        {
            this.holdNavn = holdNavn;
            this.goal = goal;
            this.win = win;
            this.loss = loss;
            this.draw = draw;
            this.matches = matches;
            this.tournWins = tournWins;

            this.playerAmount = playerAmount;
            this.division = division;
            
        }
        public Hold()
        {

        }
        public string Division
        {
            get { return division; }
            set { division = value; }
        }

        public string Draw
        {
            get { return draw; }
            set { draw = value; }
        }

        public string Goal
        {
            get { return goal; }
            set { goal = value; }
        }
        
        public string HoldNavn
        {
            get { return holdNavn; }
            set { holdNavn = value; }
        }
        
        public string Loss
        {
            get { return loss; }
            set { loss = value; }
        }

        public string Matches
        {
            get { return matches; }
            set { matches = value; }
        }

        public string PlayerAmount
        {
            get { return playerAmount; }
            set { playerAmount = value; }
        }


        public string TournWins
        {
            get { return tournWins; }
            set { tournWins = value; }
        }

        public string Win
        {
            get { return win; }
            set { win = value; }
        }
        
    }
}
