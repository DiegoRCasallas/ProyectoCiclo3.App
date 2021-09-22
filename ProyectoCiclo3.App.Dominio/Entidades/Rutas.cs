using System;
namespace ProyectoCiclo3.App.Dominio{
    public class Rutas{

        public int Id { get; set; }
        //public string Origen { get; set; }       
        public Aeropuertos Origen {get; set; }
        //public string Destino { get; set; }
        public Aeropuertos Destino {get; set; }
        public int Tiempo_Estimado { get; set; }
        
    }
}