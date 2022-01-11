using Microsoft.EntityFrameworkCore;
using DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AviationWebApi.DatabaseContext
{
    public class AviationContext: DbContext
    {
        public AviationContext(DbContextOptions<AviationContext> dbContextOptions)
: base(dbContextOptions)
        {
        
        }
        public DbSet<Airport> Airports { get; set; }

    }
}
