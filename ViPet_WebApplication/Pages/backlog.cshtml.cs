using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ViPet_opgave_U12_13;


namespace ViPet_WebApplication.Pages
{
    public class backlogModel : PageModel
    {


        private Backlogs _backlogs;

        public backlogModel(Backlogs userstories)
        {
            _backlogs = userstories;
        }

        public Backlogs Backlogs
        {
            get { return _backlogs; }
        }

        public void OnGet()
        {
        }
    }
}
