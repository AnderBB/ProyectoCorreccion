using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProyectoCiclo3.App.Persistencia.AppRepositorios;
using ProyectoCiclo3.App.Dominio;
 
namespace ProyectoCiclo3.App.Frontend.Pages
{
    public class EditBusModel : PageModel
    {
       private readonly RepositorioBuses repositorioBuses;
       [BindProperty]
       public Buses Buses {get;set;}
 
        public EditBusModel(RepositorioBuses repositorioBuses)
       {
            this.repositorioBuses=repositorioBuses;
       }
 
        public IActionResult OnGet(int busesId)
        {
            Buses=repositorioBuses.GetWithId(busesId);
            return Page();
        }

        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            if(Buses.id>0)
            {
                Buses = repositorioBuses.Update(Buses);
            }
            return RedirectToPage("./List");
        }

    }
}