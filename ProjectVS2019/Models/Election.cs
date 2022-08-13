using System.Collections.Generic;

namespace ProjectVS2019.Models
{
    public class Election : Entity
    {
        public string Name { get; set; }
        public int RegionId { get; set; }
        public Region Region { get; set; }
        public ICollection<Candidate> Candidates { get; set; } = new HashSet<Candidate>();
    }
}
