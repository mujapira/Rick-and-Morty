using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Corp.Entities
{
    public partial class CharacterEnity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public string Species { get; set; }
        public string Type { get; set; }
        public string Gender { get; set; }
        public int? OriginId { get; set; }
        public LocationEntity Origin { get; set; }
        public int? LocationId { get; set; }
        public LocationEntity Location { get; set; }
        public string Image { get; set; }
        public DateTime Created { get; set; }

        public virtual ICollection<CharacterEpisodeCharacterEntity> CharacterEpisodes { get; set; }
    }

}
