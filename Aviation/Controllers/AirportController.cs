using AviationWebApi.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AviationWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AirportController : ControllerBase
    {
        private readonly AirportRepository _airportRepository;
        public AirportController(AirportRepository airportRepository)
        {
            _airportRepository = airportRepository;
        }
        [HttpGet]
        public IActionResult GetAirports()
        {
            try
            {
                var airports = _airportRepository.GetAirports();
                return Ok(airports);
            }
            catch (System.Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

    }
}
