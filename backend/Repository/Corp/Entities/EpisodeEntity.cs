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
        public string Title { get; set; }
        public DateTime Released { get; set; }
        public string Year { get; set; }
        public string Rated { get; set; }
        public string Season { get; set; }
        public string EpisodeNumber { get; set; }
        public string Runtime { get; set; }
        public string Genre { get; set; }
        public string Director { get; set; }
        public string Writer { get; set; }
        public string Actors { get; set; }
        public string Plot { get; set; }
        public string Language { get; set; }
        public string Country { get; set; }
        public string Awards { get; set; }
        public float ImdbRating { get; set; }
        public string ImdbVotes { get; set; }
        public string ImdbId { get; set; }
        public string SeriesId { get; set; }
        public DateTime Created { get; set; }

        public virtual ICollection<CharacterEpisodeCharacterEntity> CharacterEpisodes { get; set; }
    }

}
