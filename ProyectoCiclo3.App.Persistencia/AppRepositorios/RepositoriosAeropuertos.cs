using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;
 
namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioAeropuertos
    {
        List<Aeropuertos> aeropuertos;
        private readonly AppContext _appContext = new AppContext();
        /*
        public RepositorioAeropuertos()
        {
        aeropuertos = new List<Aeropuertos>()
        {
            new Aeropuertos{Id=1,Nombre="Sachipapa Voladora",Ciudad= "Bogota",Pais="Colombia", Latitud_y=23423, Longitud_x=234234},
             new Aeropuertos{Id=2,Nombre="Sachipapa Voladora",Ciudad= "Bogota",Pais="Colombia", Latitud_y=23423, Longitud_x=234234},
             new Aeropuertos{Id=3,Nombre="Sachipapa Voladora",Ciudad= "Bogota",Pais="Colombia", Latitud_y=23423, Longitud_x=234234}
        };
        }
        SE comenta para trabajar conla base de datos y no */
        public IEnumerable<Aeropuertos> GetAll()
        {
            //return aeropuertos;  Metodo remplazado
             return _appContext.Aeropuertos;// retorna la informacion que se encuentra en aeropuertos(base de datos)
        }

        public Aeropuertos Create(Aeropuertos newAeropuerto)// Medoto que permite crear un objeto aeropuerto
        {         
            var addAeropuerto = _appContext.Aeropuertos.Add(newAeropuerto);
            _appContext.SaveChanges();
            return addAeropuerto.Entity;
        }
        
        public Aeropuertos GetAeropuertoWithId(int Id)
        {
            //return aeropuertos.SingleOrDefault(b => b.Id == Id);  
             return _appContext.Aeropuertos.Find(Id);          
        }
        
        public Aeropuertos Update(Aeropuertos newAeropuerto)
        {
           var aeropuerto = _appContext.Aeropuertos.Find(newAeropuerto.Id);
            if(aeropuerto != null)
            {
                aeropuerto.Nombre = newAeropuerto.Nombre;
                aeropuerto.Ciudad = newAeropuerto.Ciudad;
                aeropuerto.Pais = newAeropuerto.Pais;
                aeropuerto.Latitud_y = newAeropuerto.Latitud_y;
                aeropuerto.Longitud_x = newAeropuerto.Longitud_x;
                
                _appContext.SaveChanges(); //Guarda en base de Datos
            }

            return aeropuerto;
        }
        
        public void Delete(int Id)
        {            
        var aeropuerto = _appContext.Aeropuertos.Find(Id);
        if (aeropuerto == null)
            return;
        _appContext.Aeropuertos.Remove(aeropuerto);
        _appContext.SaveChanges();
        }

    }
}
    


