using System;
using System.Collections.Generic;
using System.Text;

namespace ViPet_opgave_U12_13
{
    public class Userstory
    {
        #region instance fields 


        private string _name;
        private int _id;


        #endregion

        #region Constructor 
        public Userstory() 
        { 
            _name = "";
            _id = 0;

        }

        public Userstory(string name, int id) 
        { 
            _name = name;
            _id = id;
        }

        #endregion

        #region properties 


        public string Name 
        { 
            get { return _name; } 
            set  { _name = value; } 
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
