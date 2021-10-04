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

    public class ListAvionModel : PageModel
    {
        [BindProperty]
        public Aviones avion {get;set;}
        private readonly RepositorioAviones repositorioAviones;
        public IEnumerable<Aviones> Aviones {get;set;}
 
        public ListAvionModel(RepositorioAviones repositorioAviones)
        {
        this.repositorioAviones=repositorioAviones;
        }
 
         public void OnGet()
        {
        Aviones=repositorioAviones.GetAll();
        }

        public IActionResult OnPost()
        {
            if(avion.Id>0)
            {
            avion = repositorioAviones.Delete(avion.Id);

            }
            return RedirectToPage("./List");

        }
    }
}
