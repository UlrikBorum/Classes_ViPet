using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ViPet_opgave_U12_13;


namespace ViPet_WebApplication.Pages
{
    public class backlogModel : PageModel
    {


        private Backlog _userstories;

        public backlogModel(Backlog userstories)
        {
            _userstories = userstories;
        }

        public Backlog Userstories
        {
            get { return _userstories; }
        }

        public void OnGet()
        {
        }
    }
}
