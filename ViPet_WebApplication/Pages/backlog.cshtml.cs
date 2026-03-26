using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ViPet_opgave_U12_13;


namespace ViPet_WebApplication.Pages
{
	// This is the code-behind file for the backlog page. It contains the logic for handling the requests and responses for the backlog page.
	public class backlogModel : PageModel
    {

		#region instance fields
		// We have an instance field for the Backlogs object, which is used to access the product backlog and the sprint backlog.
		private Backlogs _backlogs;

		#endregion

		#region constructor
		// We have a constructor that takes a Backlogs object as a parameter and sets the instance field to that parameter. This allows us to access the Backlogs object from the backlog page.
        public backlogModel(Backlogs backlogs)
        {
            _backlogs = backlogs;
        }
		#endregion

		#region properties
		// We also have a property for the Backlogs object, which allows us to get the value of the Backlogs object from the backlog page
        public Backlogs Backlogs
        {
            get { return _backlogs; }
        }

		#endregion

		#region methods
		public void OnGet()
        {
        }


		// We have a method for handling the POST request for deleting a user story from the product backlog.
		// This method takes an int parameter for the id of the user story that we want to delete and then calls,
		// the RemoveUserstory method on the product backlog to remove the user story with that id from the product backlog
		public void OnPostDelete(int id)
        {
            Backlogs.Product.RemoveUserstory(id);

        }
		// We have a method for handling the POST request for moving a user story from the product backlog to the sprint backlog.
		public void OnPostMove(int id)
        {
            Backlogs.MoveUserstory(id);

        }
		#endregion
	}
}
