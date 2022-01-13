using AviationWebApi.DatabaseContext;
using DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AviationWebApi.Repository
{
    public class CountryRepository
    {
        private readonly CountryContext _countryContext;
        public CountryRepository(CountryContext countryContext)
        {
            _countryContext = countryContext;
        }
        public IEnumerable<Country> GetCountries()
        {
            return _countryContext.Countries.ToList();
        }
    }
}
