using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ViPet_opgave_U12_13;

namespace ViPet_WebApplication.Pages
{
    public class Sprint_backlogModel : PageModel
    {


        private SprintBacklog _userstories;

        public Sprint_backlogModel(SprintBacklog userstories)
        {
            _userstories = userstories;
        }
        


        public SprintBacklog Userstories
        {
            get { return _userstories; }
            set { _userstories = value; }
                
        }

 

        public void OnGet()
        {
        }
    }
}
