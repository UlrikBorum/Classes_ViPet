using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace ViPet_opgave_U12_13
{
	// we create a class called Backlog. This class has a list of Userstory objects as an instance field.
	public class Backlog
    {
        #region instance fields 

        private List<Userstory> _userstories;



		#endregion

		#region Constructor 
		//We also have a default constructor that initializes the list of Userstory objects to an empty list.
		public Backlog()
        {
            _userstories = new List<Userstory>();


        }
		//We also have a constructor that takes a list of Userstory objects as a parameter and sets the instance field to that parameter.

		public Backlog(List<Userstory> userstories)
        {
            _userstories = userstories;
        }

		#endregion

		#region properties 
		//We also have a property for the list of Userstory objects, which allows us to get and set the value of the list of Userstory objects. 
		public List<Userstory> Userstories
        {
            get { return _userstories; }
            set { _userstories = value; }
        }

		#endregion

		#region methods
		//We also have methods for adding, removing, and getting Userstory objects from the list of Userstory objects.
		public void AddUserstory(Userstory us)
        {
            int id = 0;

            foreach (var item in _userstories) 
            {
                if (item.Id > id)
                {
                    id = item.Id;
                }

			}
            us.Id = id + 1;
			_userstories.Add(us);
        }


        public void RemoveUserstory(int id)
        {
            Userstory userstory = GetUserstory(id);
            if (userstory != null)
            {
                _userstories.Remove(userstory);
            }
        }
        

        public Userstory GetUserstory(int id)
        {
            Userstory resUserStory = null; // if not found
            foreach (Userstory u in _userstories)
            {
                if (u.Id == id)
                {
                    return u; // found eg. return value
                }
            }

            return resUserStory;
        }


        

        public List<Userstory> ListAll()
        {
            return new List<Userstory>(_userstories);
        }


        
        #endregion
    }
}

