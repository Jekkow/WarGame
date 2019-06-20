using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm_CardGameApplication
{
    class Card
    {
        //Values
        private int Card_Value;
        private string Card_Name;
        private string File_Name;
 
        //Constructor
        public Card(int _Value, string _Name, string _File)
        {
            Card_Value = _Value;
            Card_Name = _Name;
            File_Name = _File;
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

        public string Get_CardFileName()
        {
            return File_Name;
        }
    }
}
