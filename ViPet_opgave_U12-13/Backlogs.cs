using System;
using System.Collections.Generic;
using System.Text;

namespace ViPet_opgave_U12_13
{
    public class Backlogs
    {
        private Backlog _product;
        private Backlog _sprint;



        public Backlogs (Backlog product, Backlog sprint)
        {
            _product = product;
            _sprint = sprint;
        }


        public Backlogs()
        {
            _product = new Backlog();
            _sprint = new Backlog();

        }


        public Backlog Product { get { return _product; } set { _product = value; } }
        public Backlog Sprint {  get { return _sprint; } set  { _sprint = value; } }



        // We move a userstory from the Backlog list to the SprintBacklog list. 
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
