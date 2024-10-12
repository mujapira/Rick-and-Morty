using Microsoft.EntityFrameworkCore;
using Repository.Corp.Entities;
using Service.Service.Interfaces;
using tarefas.Corp.Context;

namespace Service.Service
{
    public class EpisodeService : IEpisodeService
    {
        private readonly CorpContext _corpContext;

        public EpisodeService(CorpContext corpContext)
        {
            _corpContext = corpContext;
        }

        public async Task<List<EpisodeEntity>> GetAllEpisodesAsync()
        {
            var episodes = await _corpContext.Episodes.ToListAsync();

            return episodes;
        }
    }
}