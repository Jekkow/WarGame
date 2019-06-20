using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cardgame
{
    class Card
    {
        //Values
        private int Card_Value;
        private string Card_Name;

        //Constructor
        public Card(int _Value, string _Name)
        {
            Card_Value = _Value;
            Card_Name = _Name;
        }

        //Getters
        public int Get_CardValue()
        {
            return Card_Value;
        }

        public string Get_CardName()
        {
            return Card_Name;
        }
    }
}
