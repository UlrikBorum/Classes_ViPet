using System;
using System.Collections.Generic;
using System.Text;

namespace ViPet_opgave_U12_13
{
    public class Userstory
    {
        #region instance fields 


        private string _text;
        private int _id;


        #endregion

        #region Constructor 
        public Userstory() 
        { 
            _text = "";
            _id = 0;

        }


        public Userstory(string text, int id) 
        { 
            _text = text;
            _id = id;
        }

        #endregion

        #region properties 


        public string Text 
        { 
            get { return _text; } 
            set  { _text = value; } 
        }
        public int Id 
        { 
            get { return _id; } 
            set { _id = value; } 
        }
        #endregion

        #region methods


        #endregion






    }
}
