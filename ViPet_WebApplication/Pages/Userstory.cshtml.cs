using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ViPet_opgave_U12_13;

namespace ViPet_WebApplication.Pages
{
    public class UserstoryModel : PageModel
    {
        private Userstory _us;


     

        public UserstoryModel (Userstory userstory)
        {
            _us = userstory;
         
        }

        public Userstory Us
        {
            get { return _us; } 
        }

     

		public void OnGet()
        {
        }
    }
}
