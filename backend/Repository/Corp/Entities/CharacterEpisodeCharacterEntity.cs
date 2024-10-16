﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Corp.Entities
{
    public partial class CharacterEpisodeCharacterEntity
    {
        public int CharacterId { get; set; }
        public virtual CharacterEntity Character { get; set; } = new CharacterEntity();

        public int EpisodeId { get; set; }
        public virtual EpisodeEntity Episode { get; set; } = new EpisodeEntity();
    }

}
