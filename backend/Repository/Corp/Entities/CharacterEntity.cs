using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Corp.Entities
{
    public partial class CharacterEntity
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public string Species { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        public string Gender { get; set; } = string.Empty;
        public int? OriginId { get; set; } = null;
        public LocationEntity Origin { get; set; } = new LocationEntity();
        public int? LocationId { get; set; } = null;
        public LocationEntity Location { get; set; } = new LocationEntity();
        public string Image { get; set; } = string.Empty;
        public DateTime Created { get; set; }

        public virtual ICollection<CharacterEpisodeCharacterEntity> CharacterEpisodes { get; set; } = new List<CharacterEpisodeCharacterEntity>();
    }

}
