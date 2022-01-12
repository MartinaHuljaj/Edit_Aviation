using DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace AviationBlazorServer.Services
{
    public class AirportService
    {
        private readonly HttpClient _httpClient;
        private readonly string BaseApiUrl = "https://localhost:44365/api/Airport";
        public AirportService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<Airport>> GetAirports()
        {
            return await _httpClient.GetFromJsonAsync<List<Airport>>(BaseApiUrl);

        }
    }
}
