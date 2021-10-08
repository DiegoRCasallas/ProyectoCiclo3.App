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
    public class EditAeropuertoModel : PageModel
    {
        private readonly RepositorioAeropuertos repositorioAeropuertos;
        [BindProperty]
        public Aeropuertos Aeropuerto {get;set;}
        
        public EditAeropuertoModel(RepositorioAeropuertos repositorioAeropuertos)
        {
            this.repositorioAeropuertos=repositorioAeropuertos;
        }
        
        public IActionResult OnGet(int aeropuertoId)
        {
            Aeropuerto=repositorioAeropuertos.GetAeropuertoWithId(aeropuertoId);
            return Page(); 
        }
        
        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            if(Aeropuerto.Id>0)
            {
            Aeropuerto = repositorioAeropuertos.Update(Aeropuerto);
            }
            return RedirectToPage("./List");
        }

    }
}