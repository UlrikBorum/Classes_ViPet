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
        public Backlog sprint {  get { return _sprint; } set  { _sprint = value; } }




        public Backlogs MoveUserstory(int id)
        {
            Backlogs newBacklogs = new Backlogs(_product,_sprint);

            foreach (Userstory us in _product.Userstories)
            {
                if (id == us.Id)
                {
                    _sprint.AddUserstory(us);
                    _product.Userstories.Remove(us);
                    return newBacklogs;
                }
            }
            return null;
        }
    }
}
