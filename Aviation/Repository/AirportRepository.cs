
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
    }



}
