using Microsoft.EntityFrameworkCore;
using ProyectoCiclo3.App.Dominio;
 
namespace ProyectoCiclo3.App.Persistencia
{
    public class AppContext: DbContext
    {
        // Se agregan las entidades que seran conectadas a la base de datos mediante el DbSet
        public DbSet<Aviones> Aviones { get; set; }
        public DbSet<Aeropuertos> Aeropuertos { get; set; }
        public DbSet<Rutas> Rutas { get; set; }
        
        //poner los public debSet de las otras entidadescls
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            if(!optionsBuilder.IsConfigured){
                optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = ProyectoCiclo3_1.0");
            }
        }
    }
}
