
using AviationWebApi.DatabaseContext;
using DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AviationWebApi.Repository
{

    public class AirportRepository
    {
        private readonly AviationContext _aviationContext;
        public AirportRepository(AviationContext aviationContext)
        {
            _aviationContext = aviationContext;
        }
        public IEnumerable<Airport> GetAirports()
        {
            return _aviationContext.Airports.ToList();
        }
        public void InsertAirport(Airport airport)
        {
            _aviationContext.Airports.Add(airport);
            _aviationContext.SaveChanges();

        }
        public void UpdateAirport(Airport airport)
        {
            var airportForUpdate = GetAirport(airport.Id);
            if (airportForUpdate != null)
            {
                airportForUpdate.Name = airport.Name;
                airportForUpdate.Address = airport.Address;
                _aviationContext.SaveChanges();
            }
        }

        public Airport GetAirport(int airportId)
        {
            return _aviationContext.Airports.FirstOrDefault(airport => airport.Id.Equals(airportId));
        }

        public void DeleteAirport(int airportId)
        {
            var airportForDelete = GetAirport(airportId);
            if (airportForDelete != null)
            {
                _aviationContext.Airports.Remove(airportForDelete);
                _aviationContext.SaveChanges();
            }
        }

    }




}
