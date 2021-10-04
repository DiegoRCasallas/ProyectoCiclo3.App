using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;
 
namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioAeropuertos
    {
        List<Aeropuertos> aeropuertos;

 public RepositorioAeropuertos()
    {
   aeropuertos = new List<Aeropuertos>()
        {
            new Aeropuertos{Id=1,Nombre="Sachipapa Voladora",Ciudad= "Bogota",Pais="Colombia", Latitud_y=23423, Longitud_x=234234},
             new Aeropuertos{Id=2,Nombre="Sachipapa Voladora",Ciudad= "Bogota",Pais="Colombia", Latitud_y=23423, Longitud_x=234234},
             new Aeropuertos{Id=3,Nombre="Sachipapa Voladora",Ciudad= "Bogota",Pais="Colombia", Latitud_y=23423, Longitud_x=234234}
        };
        }
 
        public IEnumerable<Aeropuertos> GetAll()
        {
            return aeropuertos;
        }
 
        public Aeropuertos GetAeropuertoWithId(int Id){
            return aeropuertos.SingleOrDefault(b => b.Id == Id);
            
        }
        public Aeropuertos Update(Aeropuertos newAeropuerto){
            var aeropuerto = aeropuertos.SingleOrDefault(b => b.Id == newAeropuerto.Id);
            if(aeropuerto != null){
                aeropuerto.Nombre = newAeropuerto.Nombre;
                aeropuerto.Ciudad = newAeropuerto.Ciudad;
                aeropuerto.Pais = newAeropuerto.Pais;
                aeropuerto.Latitud_y = newAeropuerto.Latitud_y;
                aeropuerto.Longitud_x = newAeropuerto.Longitud_x;
            }
        return aeropuerto;
        }
    }
}
