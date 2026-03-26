using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ViPet_opgave_U12_13;
namespace ViPet_WebApplication.Pages
{
	// This is the code-behind file for the create user story page. It contains the logic for handling the requests and responses for the create user story page.
	public class CreateUserstoryModel : PageModel
   {
		#region instance fields
		private Backlogs _backlogs;
		#endregion

		#region constructor
		// We have a constructor that takes a Backlogs object as a parameter and sets the instance field to that parameter.
        public CreateUserstoryModel(Backlogs userstory)
        {
            _backlogs = userstory;
		}
		#endregion

		#region properties
		// We also have a property for the Backlogs object, which allows us to get the value of the Backlogs object from the create user story page.
		// we dont use set because we only want to get the value of the Backlogs object from the create user story page and not set it from the create user story page.
		public Backlogs Backlogs
        {
            get { return _backlogs; }
		}
		// We also have a property for the Userstory object, which allows us to get and set the value of the Userstory object from the create user story page.
       
		private Userstory _userstory;

         // This property is used to bind the values from the form on the create user story page to the Userstory object.
        [BindProperty]
        public Userstory Userstory
        {
            get { return _userstory; }
            set { _userstory = value; }
		}
		#endregion

		public void OnGet()
        {
        }

        // We have a method for handling the POST request for creating a new user story.
        // This method takes the values from the form and creates a new Userstory object with those values and then adds that user story to the product backlog.
        public IActionResult OnPost()
        {
            UserstoryDetail empty = new UserstoryDetail();
            Userstory newUserstory = new Userstory(Userstory.Name, Userstory.Id, empty);

            Backlogs.Product.AddUserstory(newUserstory);

            return RedirectToPage("/Backlog");
		}

    }
}
