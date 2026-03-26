using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ViPet_opgave_U12_13;


namespace ViPet_WebApplication.Pages
{
    public class backlogModel : PageModel
    {

		#region instance fields

		private Backlogs _backlogs;

		#endregion

		#region constructor
		public backlogModel(Backlogs backlogs)
        {
            _backlogs = backlogs;
        }
		#endregion

		#region properties
		public Backlogs Backlogs
        {
            get { return _backlogs; }
        }

		#endregion

		#region methods
		public void OnGet()
        {
        }

        

        public void OnPostDelete(int id)
        {
            Backlogs.Product.RemoveUserstory(id);

        }

        public void OnPostMove(int id)
        {
            Backlogs.MoveUserstory(id);

        }
		#endregion
	}
}
