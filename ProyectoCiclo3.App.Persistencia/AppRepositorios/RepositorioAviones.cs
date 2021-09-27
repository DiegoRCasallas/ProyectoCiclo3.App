using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;
 
namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioAviones
    {
        List<Aviones> aviones;

 public RepositorioAviones()
    {
   aviones = new List<Aviones>()
        {
            new Aviones{Id=1,Marca="Airbus",Modelo= 2020,Numero_asientos= 4, Numero_banos= 4, Capacidad_maxima=150},
            new Aviones{Id=2,Marca="Boeing 787",Modelo= 2021,Numero_asientos= 16, Numero_banos= 4, Capacidad_maxima=200},
            new Aviones{Id=3,Marca="Airbus A319",Modelo= 2000,Numero_asientos= 24, Numero_banos= 4, Capacidad_maxima=80}
        };
        }
 
        public IEnumerable<Aviones> GetAll()
        {
            return aviones;
        }
 
        public Aviones GetAvionWithId(int Id){
            return aviones.SingleOrDefault(b => b.Id == Id);
        }
    }
}
