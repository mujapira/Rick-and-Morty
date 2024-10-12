using Microsoft.EntityFrameworkCore;
using Repository.Corp.Entities;
using Service.Service.Interfaces;
using tarefas.Corp.Context;

namespace Service.Service
{
    public class LocationService : ILocationService
    {
        private readonly CorpContext _corpContext;

        public LocationService(CorpContext corpContext)
        {
            _corpContext = corpContext;
        }

        public async Task<List<LocationEntity>> GetAllLocationsAsync()
        {
            var locations = await _corpContext.Locations.ToListAsync();

            return locations;
        }
    }
}