using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ViPet_opgave_U12_13;
namespace ViPet_WebApplication.Pages
{
    public class CreateUserstoryModel : PageModel
   {
       private Backlogs _backlogs;

       public CreateUserstoryModel(Backlogs userstory)
        {
            _backlogs = userstory;
		}

        public Backlogs Backlogs
        {
            get { return _backlogs; }
		}

		private Userstory _userstory;


       

        [BindProperty]
        public Userstory Userstory
        {
            get { return _userstory; }
            set { _userstory = value; }
		}
    

		public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            UserstoryDetail empty = new UserstoryDetail();
            Userstory newUserstory = new Userstory(Userstory.Name, Userstory.Id, empty);

            Backlogs.Product.AddUserstory(newUserstory);

            return RedirectToPage("/Backlog");
		}

    }
}
