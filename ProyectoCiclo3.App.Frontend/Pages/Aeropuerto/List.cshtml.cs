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
    public class ListAeropuertoModel : PageModel
    {
        [BindProperty]
        public Aeropuertos aeropuerto {get;set;}
        private readonly RepositorioAeropuertos repositorioAeropuertos;       
        public IEnumerable<Aeropuertos> Aeropuertos {get;set;}
 
        public ListAeropuertoModel(RepositorioAeropuertos repositorioAeropuertos)
        {
        this.repositorioAeropuertos=repositorioAeropuertos;
        }

        public void OnGet()
        {
         Aeropuertos=repositorioAeropuertos.GetAll();
        }

        public IActionResult OnPost()
        {
            if(aeropuerto.Id>0)
            {
             repositorioAeropuertos.Delete(aeropuerto.Id);
            }
            return RedirectToPage("./List");

        }
    }
}

    
