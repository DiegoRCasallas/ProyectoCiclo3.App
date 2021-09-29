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
    public class EditAvionModel : PageModel
    {
        private readonly RepositorioAviones repositorioAviones;
        [BindProperty]
        public Aviones Avion {get;set;}
public EditAvionModel(RepositorioAviones repositorioAviones)
       {
            this.repositorioAviones=repositorioAviones;
       }
public IActionResult OnGet(int avionId)
        {
            Avion=repositorioAviones.GetAvionWithId(avionId);
            return Page(); 
        }
public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            if(Avion.Id>0)
            {
            Avion = repositorioAviones.Update(Avion);
            }
            return Page();
        }

    }
}