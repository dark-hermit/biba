namespace ProjectVS2019.Models
{
    public class Entity
    {
        public int Id { get; set; }

        public override int GetHashCode() => Id;

        public override bool Equals(object obj)
        {
            return base.Equals(obj)
                && obj is Entity entity
                && entity.Id == Id
                && obj.GetType().FullName == GetType().FullName;
        }
    }
}
