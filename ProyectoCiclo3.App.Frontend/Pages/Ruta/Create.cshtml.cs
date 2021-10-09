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
        private readonly RepositorioAeropuertos repositorioAeropuertos;
        public IEnumerable<Aeropuertos> Aeropuertos {get;set;}
        [BindProperty]
        public Rutas Ruta {get;set;}
 
        public FormRutaModel(RepositorioRutas repositorioRutas, RepositorioAeropuertos repositorioAeropuertos)
        {
            this.repositorioRutas=repositorioRutas;
            this.repositorioAeropuertos=repositorioAeropuertos;
        }
 
        public void OnGet()
        {
            Aeropuertos = repositorioAeropuertos.GetAll();
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
