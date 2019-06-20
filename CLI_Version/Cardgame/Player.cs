using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cardgame
{
    class Player
    {
        //Values
        private int Player_ID;
        private string Player_Name;
        private int Player_Score;
        public List<Card> PlayerHand = new List<Card>();

        //Constructor
        public Player(int _ID, string _Name, int _Score)
        {
            Player_ID = _ID;
            Player_Name = _Name;
            Player_Score = _Score;
        }

        //Getters
        public int Get_PlayerID()
        {
            return Player_ID;
        }

        public string Get_PlayerName()
        {
            return Player_Name;
        }

        public int Get_PlayerScore()
        {
            return Player_Score;
        }

        //Setters
        public void Set_PlayerScore(int _Score)
        {
            Player_Score = Player_Score + _Score;
        }
    }
}
