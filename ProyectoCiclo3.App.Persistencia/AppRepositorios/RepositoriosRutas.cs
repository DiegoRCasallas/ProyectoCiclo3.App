using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;
using Microsoft.EntityFrameworkCore;

namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioRutas
    {
        
         List<Rutas> rutas;
        private readonly AppContext _appContext = new AppContext();
           
        public IEnumerable<Rutas> GetAll()
         {
           return _appContext.Rutas.Include(u => u.Origen)
                       .Include(u => u.Destino);
                     
        }

        
       public Rutas Create(int Origen, int Destino, int Tiempo_Estimado)
        {
            var newRuta = new Rutas();
            newRuta.Destino = _appContext.Aeropuertos.Find(Origen);;
            newRuta.Origen = _appContext.Aeropuertos.Find(Destino);          
            newRuta.Tiempo_Estimado = Tiempo_Estimado;
 
            var addRuta = _appContext.Rutas.Add(newRuta);
            _appContext.SaveChanges();
            return addRuta.Entity;
        }


        
        public Rutas GetRutaWithId(int Id)
        {
          
           return _appContext.Rutas.Find(Id); 
        }

        public Rutas Update(Rutas newRuta)
        {
            var ruta = _appContext.Rutas.Find(newRuta.Id);
            if(ruta != null)
            {
                ruta.Origen = newRuta.Origen;
                ruta.Destino = newRuta.Destino;
                ruta.Tiempo_Estimado = newRuta.Tiempo_Estimado;                      
                _appContext.SaveChanges(); //Guarda en base de Datos
            }
            return ruta;
        }

        public void Delete(int Id)
        {           
        var ruta = _appContext.Rutas.Find(Id);
        if (ruta == null)
            return;
        _appContext.Rutas.Remove(ruta);
        _appContext.SaveChanges();
        }

    }
}
