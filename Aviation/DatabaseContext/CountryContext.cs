using DomainModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AviationWebApi.DatabaseContext
{
    public class CountryContext :DbContext
    {
        public CountryContext(DbContextOptions<CountryContext> dbContextOptions)
: base(dbContextOptions)
        {

        }
        public DbSet<Country> Countries { get; set; }
    }
}
