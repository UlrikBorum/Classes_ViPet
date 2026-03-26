using System;
using System.Collections.Generic;
using System.Text;

namespace ViPet_opgave_U12_13

// // we create a class called Userstories. This class has a string field called Text and an int called id
	public class Userstory
    {
        #region instance fields 


        private string _name;
        private int _id;
        
        private UserstoryDetail _userstoryDetail;

	#endregion

	#region Constructor 
	// We also have a default constructor that sets the Text field to an empty string, and int field to value = 0, and set usterstory to become a new object of UserstoryDetail
	public Userstory() 
        { 
            _name = "";
            _id = 0;
            _userstoryDetail = new UserstoryDetail();
        }
	//We also have a constructor that takes a string parameter and sets the Text field to that parameter, int parameter and sets the value field to that parameter and we also havea constructor that takes userstorydetail objects as parameters and sets the instance fields to those parameters.
	public Userstory(string name, int id, UserstoryDetail userstoryDetail) 
        { 
            _name = name;
            _id = id;
            _userstoryDetail = userstoryDetail;
        }

	#endregion

	#region properties 
	//We also have a property for the Text, id, userstory field, which allows us to get and set the value of the those fields.

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
