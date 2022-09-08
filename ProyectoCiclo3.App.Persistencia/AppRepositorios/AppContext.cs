using Microsoft.EntityFrameworkCore;
using ProyectoCiclo3.App.Dominio;
 
namespace ProyectoCiclo3.App.Persistencia
{
    public class AppContext: DbContext{
        public DbSet<Estaciones> Estaciones { get; set; }
        public DbSet<Rutas> Rutas { get; set; }
        public DbSet<Buses> Buses { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            if(!optionsBuilder.IsConfigured){
                optionsBuilder.UseSqlServer("Server=tcp:servidorapp.database.windows.net,1433;Initial Catalog=BDAPPTRANSPORTE;Persist Security Info=False;User ID=usuariomvg83;Password=Largon-2022;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }
    }
}