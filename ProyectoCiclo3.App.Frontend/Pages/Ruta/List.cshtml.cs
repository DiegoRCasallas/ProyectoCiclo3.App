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
    public class ListRutaModel : PageModel
    {
       
        private readonly RepositorioRutas repositorioRutas;
        public IEnumerable<Rutas> Rutas {get;set;}
 
    public ListRutaModel(RepositorioRutas RepositorioRutas)
    {
        this.repositorioRutas=repositorioRutas;
     }
 
    public void OnGet()
    {
        Rutas=repositorioRutas.GetAll();
    }
    }
}
