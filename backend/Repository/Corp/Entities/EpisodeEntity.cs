using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Corp.Entities
{
    public partial class EpisodeEntity
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public DateTime Released { get; set; }
        public string Year { get; set; } = string.Empty;
        public string Rated { get; set; } = string.Empty;
        public string Season { get; set; } = string.Empty;
        public string EpisodeNumber { get; set; } = string.Empty;
        public string Runtime { get; set; } = string.Empty;
        public string Genre { get; set; } = string.Empty;
        public string Director { get; set; } = string.Empty;
        public string Writer { get; set; } = string.Empty;
        public string Actors { get; set; } = string.Empty;
        public string Plot { get; set; } = string.Empty;
        public string Language { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public string Awards { get; set; } = string.Empty;
        public float ImdbRating { get; set; }
        public string ImdbVotes { get; set; } = string.Empty;
        public string ImdbId { get; set; } = string.Empty;
        public string SeriesId { get; set; } = string.Empty;
        public DateTime Created { get; set; }

        public virtual ICollection<CharacterEpisodeCharacterEntity> CharacterEpisodes { get; set; } = new List<CharacterEpisodeCharacterEntity>();
    }

}
