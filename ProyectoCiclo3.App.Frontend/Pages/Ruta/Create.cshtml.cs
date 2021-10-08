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
    public class FormRutaModel : PageModel
    {
         private readonly RepositorioRutas repositorioRutas;
        [BindProperty]
        public Rutas Ruta {get;set;}
 
        public FormRutaModel(RepositorioRutas repositorioRutas)
        {
            this.repositorioRutas=repositorioRutas;
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
            Ruta = repositorioRutas.Create(Ruta);            
            return RedirectToPage("./List");
        }
    }
}
