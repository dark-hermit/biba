using System.Collections.Generic;

namespace ProjectVS2019.Models
{
    public class Region : Entity
    {
        public string Name { get; set; }
        public ICollection<Election> Votes { get; set; } = new HashSet<Election>();
    }
}
