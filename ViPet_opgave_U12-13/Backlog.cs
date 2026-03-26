using System;
using System.Collections.Generic;
using System.Text;

namespace ViPet_opgave_U12_13
{
    public class Backlog
    {
        #region instance fields 
        // This field is a list of userstories in the backlog.
        private List<Userstory> _userstories;



        #endregion

        #region Constructor 
        // This constructor initializes the backlog with an empty list of userstories.
        public Backlog()
        {
            _userstories = new List<Userstory>();


        }
        // This constructor initializes the backlog with a given list of userstories.
        public Backlog(List<Userstory> userstories)
        {
            _userstories = userstories;
        }

        #endregion

        #region properties 
        // This property allows access to the list of userstories in the backlog.
        public List<Userstory> Userstories
        {
            get { return _userstories; }
            set { _userstories = value; }
        }

        #endregion

        #region methods
        // This method adds a userstory to the backlog. It contains a parameter of type Userstory.
        // The method should automatically assign an id to the userstory, which is one higher than the highest id currently in the backlog.
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

        // This method takes an id as a parameter and removes the userstory with that id from the backlog. If no userstory with that id exists, the method should do nothing.
        public void RemoveUserstory(int id)
        {
            Userstory userstory = GetUserstory(id);
            if (userstory != null)
            {
                _userstories.Remove(userstory);
            }
        }

        // This method takes an id as a parameter and returns the userstory with that id. If no userstory with that id exists, it should return null.
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



        // This method returns a list of all userstories in the backlog.
        public List<Userstory> ListAll()
        {
            return new List<Userstory>(_userstories);
        }


        
        #endregion
    }
}

