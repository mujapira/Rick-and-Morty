﻿using Repository.Corp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Service.Interfaces
{
    public interface IEpisodeService
    {
        Task<List<EpisodeEntity>> GetAllEpisodesAsync();
    }
}
