
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ViPet_opgave_U12_13;

namespace ViPet_WebApplication.Pages
{
	//// This is the code-behind file for the create user story page. It contains the logic for handling the requests and responses for the create user story page.
	public class Sprint_backlogModel : PageModel
    {

		#region instance field
		private Backlogs _backlogs;
		#endregion

		#region constructor
		public Sprint_backlogModel(Backlogs backlogs)
        {
            _backlogs = backlogs;
        }
		#endregion

		#region properties
		public Backlogs Backlogs
        {
            get { return _backlogs; }
            set { _backlogs = value; }
        }
		#endregion

		#region methods
		public void OnGet()
        {
        }

        public void OnPostDelete(int id)
        {
           
            Backlogs.Sprint.RemoveUserstory(id);
        
        }

		#endregion
	}
}
