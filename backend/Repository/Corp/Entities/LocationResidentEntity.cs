using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Corp.Entities
{
    public partial class LocationResidentEntity
    {
        public int LocationId { get; set; }
        public LocationEntity Location { get; set; } = null!;

        public int ResidentId { get; set; }
        public virtual CharacterEntity Resident { get; set; } = null!;
    }

}
