using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ViPet_opgave_U12_13;

namespace ViPet_WebApplication.Pages
{
    public class Sprint_backlogModel : PageModel
    {


        private Backlogs _backlogs;

        public Sprint_backlogModel(Backlogs backlogs)
        {
            _backlogs = backlogs;
        }
        


        public Backlogs Backlogs
        {
            get { return _backlogs; }
            set { _backlogs = value; }
                
        }

 

        public void OnGet()
        {
        }
    }
}
