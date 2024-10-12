using Microsoft.EntityFrameworkCore;
using Repository.Corp.Entities;
using Service.Service.Interfaces;
using tarefas.Corp.Context;

namespace Service.Service
{
    public class CharacterService : ICharacterService
    {
        private readonly CorpContext _corpContext;

        public CharacterService(CorpContext corpContext)
        {
            _corpContext = corpContext;
        }

        public async Task<List<CharacterEntity>> GetAllCharactersAsync()
        {
            var characters = await _corpContext.Characters.ToListAsync();

            return characters;
        }
    }
}