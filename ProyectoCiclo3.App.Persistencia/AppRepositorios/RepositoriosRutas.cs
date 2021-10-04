using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;
namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioRutas
    {
        
        List<Rutas> rutas;

 public RepositorioRutas()
    {
    
   rutas = new List<Rutas>()
        {
            
        };
        }
 
        public IEnumerable<Rutas> GetAll()
        {
            return rutas;
        }
 
        public Rutas GetRutaWithId(int Id){
            return rutas.SingleOrDefault(b => b.Id == Id);
            
        }
        public Rutas Update(Rutas newRuta){
            var ruta = rutas.SingleOrDefault(b => b.Id == newRuta.Id);
            if(ruta != null){
                ruta.Origen = newRuta.Origen;
                ruta.Destino = newRuta.Destino;
                ruta.Tiempo_Estimado = newRuta.Tiempo_Estimado;
                
            }
        return ruta;
        }
    }
}
