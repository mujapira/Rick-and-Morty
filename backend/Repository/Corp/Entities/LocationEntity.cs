﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Corp.Entities
{
    public partial class LocationEntity
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        public string Dimension { get; set; } = string.Empty;
        public DateTime Created { get; set; }
        public virtual ICollection<LocationResidentEntity> Residents { get; set; } = new List<LocationResidentEntity>();
    }

}
