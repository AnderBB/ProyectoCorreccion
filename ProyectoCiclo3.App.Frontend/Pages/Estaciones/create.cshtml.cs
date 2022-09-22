using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
<<<<<<< HEAD
using Microsoft.AspNetCore.Authorization;
=======
using ProyectoCiclo3.App.Persistencia.AppRepositorios;
using ProyectoCiclo3.App.Dominio;
>>>>>>> 975e633f8d7a4ea06cfc978513f5ede722428ed4
 
namespace ProyectoCiclo3.App.Frontend.Pages
{
        [Authorize]
    public class FormEstacionesModel : PageModel
    {   
        private readonly RepositorioEstaciones repositorioEstaciones;
        [BindProperty]
        public  Estaciones Estacion {get;set;}

        public FormEstacionesModel(RepositorioEstaciones repositorioEstaciones)
        {
            this.repositorioEstaciones=repositorioEstaciones;
        }

        public void OnGet()
        {   
        }

        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            repositorioEstaciones.Create(Estacion);
            return RedirectToPage("./List");
        }
    }
}