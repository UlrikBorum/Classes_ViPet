using System;
using System.Collections.Generic;
using System.Text;

namespace ViPet_opgave_U12_13
{
    public class Backlog
    {
        #region instance fields 

        private List<Userstory> _userstories;

   

        #endregion

        #region Constructor 

        public Backlog()
        {
            _userstories = new List<Userstory>();


        }

        public Backlog(List<Userstory> userstories)
        {
            _userstories = userstories;
        }



        #endregion

        #region properties 

        public List<Userstory> Userstories
        {
            get { return _userstories; }
            set { _userstories = value; }
        }

        #endregion

        #region methods

        public void AddUserstory(Userstory us)
        { 
            _userstories.Add(us);
        }

        public List<Userstory> RemoveUserstory(int id)
        {
            foreach (Userstory us in _userstories)
            {
                if (id == us.Id)
                {
                    _userstories.Remove(us);

                    return _userstories;
                }

             }

            return null;
        }
        
        public List<Userstory> MoveUserstory (int id, Backlog targetBacklog)
        {
            foreach (Userstory us in _userstories)
            {
                if (id == us.Id)
                {
                    targetBacklog.AddUserstory(us);
                    _userstories.Remove(us);
                    return _userstories;
                }
            }
            return null;
		}

		#endregion
	}
}
