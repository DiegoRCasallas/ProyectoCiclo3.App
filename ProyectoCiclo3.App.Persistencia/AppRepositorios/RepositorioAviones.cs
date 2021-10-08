using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;
 
namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioAviones
    {

        List<Aviones> aviones;
        private readonly AppContext _appContext = new AppContext();

            /*
            public RepositorioAviones()
            {
            aviones = new List<Aviones>()
                {
                    new Aviones{Id=1,Marca="Airbus",Modelo= 2020,Numero_asientos= 4, Numero_banos= 4, Capacidad_maxima=150},
                    new Aviones{Id=2,Marca="Boeing 787",Modelo= 2021,Numero_asientos= 16, Numero_banos= 4, Capacidad_maxima=200},
                    new Aviones{Id=3,Marca="Airbus A319",Modelo= 2000,Numero_asientos= 24, Numero_banos= 4, Capacidad_maxima=80}
                };
                }
            */
        public IEnumerable<Aviones> GetAll()
        {
            //return aviones;-->Metodo reemplazado
            return _appContext.Aviones;// retorna la informacion que se encuentra en aviones(base de datos)
        }
        
        public Aviones Create(Aviones newAvion)
        {
           /*
           if(aviones.Count > 0){
           newAvion.Id=aviones.Max(r => r.Id) +1; 
            }else{
               newAvion.Id = 1; 
            }
           aviones.Add(newAvion);
           return newAvion;
           */
        var addAvion = _appContext.Aviones.Add(newAvion);
        _appContext.SaveChanges();
        return addAvion.Entity;
        }
        
        public Aviones GetAvionWithId(int Id)
        {
           // return aviones.SingleOrDefault(b => b.Id == Id);
           return _appContext.Aviones.Find(Id); 
        }

        public Aviones Update(Aviones newAvion)
        {
            var avion = aviones.SingleOrDefault(b => b.Id == newAvion.Id);
            if(avion != null)
            {
                avion.Marca = newAvion.Marca;
                avion.Modelo = newAvion.Modelo;
                avion.Numero_banos = newAvion.Numero_banos;
                avion.Numero_asientos = newAvion.Numero_asientos;
                avion.Capacidad_maxima = newAvion.Capacidad_maxima;
                
                _appContext.SaveChanges(); //Guarda en base de Datos
            }
        return avion;
        }

        public void Delete(int Id)
        {
            /*
            var avion= aviones.SingleOrDefault(b => b.Id == Id);
            aviones.Remove(avion);
            return avion;
            */
        var avion = _appContext.Aviones.Find(Id);
        if (avion == null)
            return;
        _appContext.Aviones.Remove(avion);
        _appContext.SaveChanges();
        }

    }
}
