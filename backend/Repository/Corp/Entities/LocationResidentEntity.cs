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
        public LocationEntity Location { get; set; }

        public int ResidentId { get; set; }
        public virtual CharacterEnity Resident { get; set; }
    }

}
