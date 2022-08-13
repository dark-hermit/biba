namespace ProjectVS2019.Models
{
    public class Vote : Entity
    {
        public bool IsVoted { get; set; }
        public int VoteId { get; set; }
        public Election Election { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
