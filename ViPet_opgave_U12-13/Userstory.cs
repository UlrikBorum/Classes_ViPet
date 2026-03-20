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
        
        private UserstoryDetail _userstoryDetail;

		#endregion

		#region Constructor 
		public Userstory() 
        { 
            _name = "";
            _id = 0;
            _userstoryDetail = new UserstoryDetail();
        }

        public Userstory(string name, int id, UserstoryDetail userstoryDetail) 
        { 
            _name = name;
            _id = id;
            _userstoryDetail = userstoryDetail;
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

        public UserstoryDetail UserstoryDetail 
        { 
            get { return _userstoryDetail; } 
            set { _userstoryDetail = value; }
		}
		#endregion

		#region methods


		#endregion






	}
}
