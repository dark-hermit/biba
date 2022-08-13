namespace ProjectVS2019.Models
{
    public class Candidate : Entity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronymic { get; set; }
        public string Description { get; set; }
        public int VoteId { get; set; }
        public Election Vote { get; set; }
    }
}
