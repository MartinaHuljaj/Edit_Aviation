using AviationWebApi.Repository;
using DomainModel;
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

        [HttpPost]
        public IActionResult AddAirport([FromBody] Airport airport)
        {
            if (airport == null)
            {
                return BadRequest();
            }
            try
            {
                _airportRepository.InsertAirport(airport);
                return Ok();
            }
            catch(System.Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpPut]
        public IActionResult UpdateAirport([FromBody] Airport airport)
        {
            if (airport == null)
            {
                return BadRequest();
            }

            try
            {
                _airportRepository.UpdateAirport(airport);
                return Ok();
            }
            catch (System.Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpGet("{airportId:int}")]
        public IActionResult GetAirport(int airportId)
        {
            try
            {
                return Ok(_airportRepository.GetAirport(airportId));
            }
            catch (System.Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

    }
}
