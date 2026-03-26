using System;
using System.Collections.Generic;
using System.Text;

namespace ViPet_opgave_U12_13
{
	// we made a class called Backlogs.
	
	public class Backlogs
    {
		#region instance fields
		//his class has two instance fields, one for the product backlog and one for the sprint backlog.Both of these fields are of type Backlog.
		private Backlog _product;
        private Backlog _sprint;
		#endregion

		#region constructor
		// we also havea constructor that takes two Backlog objects as parameters and sets the instance fields to those parameters.
		public Backlogs (Backlog product, Backlog sprint)
        {
            _product = product;
            _sprint = sprint;
        }


		// we also have a default constructor that initializes both instance fields to new Backlog objects.
		public Backlogs()
        {
            _product = new Backlog();
            _sprint = new Backlog();

        }

		#endregion

		#region properties
		// we also have properties for both instance fields, which allow us to get and set the value of both instance fields.
		public Backlog Product { get { return _product; } set { _product = value; } }
        public Backlog Sprint {  get { return _sprint; } set  { _sprint = value; } }
		#endregion


		// We move a userstory from the Backlog list to the SprintBacklog list. 

		// We do this by iterating through the list of userstories in the product backlog and checking if the id of the userstory matches the id that we want to move.
        // If it does, we store that userstory in a variable and then add it to the sprint backlog and remove it from the product backlog.
		public void MoveUserstory(int id)
        {
            Userstory moveUS = null;
            foreach (Userstory us in _product.Userstories)
            {
                if (id == us.Id)
                {
                    moveUS = us;
                    
                   
                }
            }
            _sprint.AddUserstory(moveUS);
            _product.Userstories.Remove(moveUS);
        }
    }
}
