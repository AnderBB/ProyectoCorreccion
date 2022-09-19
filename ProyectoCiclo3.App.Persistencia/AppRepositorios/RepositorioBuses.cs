using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;
 
namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioBuses
    {
        List<Buses> estaciones;
        private readonly AppContext _appContext = new AppContext();
 
        public IEnumerable<Buses> GetAll()
        {
            return _appContext.Buses;
        }
 
        public Buses GetWithId(int id){
            return _appContext.Buses.Find(id);
        }

        public Buses Update(Buses newBuses){
            var buses = _appContext.Buses.Find(newBuses.id);;
            if(buses != null){
                buses.marca = newBuses.marca;
                buses.modelo = newBuses.modelo;
                buses.kilometraje = newBuses.kilometraje;
                buses.numero_asientos = newBuses.numero_asientos;
                
                //Guardar en base de datos
                 _appContext.SaveChanges();
            }
        return buses;
        }

        public Buses Create(Buses newBuses)
        {
            var addEstacion = _appContext.Buses.Add(newBuses);
            //Guardar en base de datos
            _appContext.SaveChanges();
            return addEstacion.Entity;
        }

        public Buses Delete(int id)
        {
            var buses = _appContext.Buses.Find(id);
            if (buses != null){
                _appContext.Buses.Remove(buses);
                //Guardar en base de datos
                _appContext.SaveChanges();
            }
            return null;
        }

    }
}