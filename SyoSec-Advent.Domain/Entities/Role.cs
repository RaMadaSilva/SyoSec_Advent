namespace SyoSec_Advent.Domain.Entities
{
    public class Role : Entity
    {
        public string RoleName { get; private set; }
        public IReadOnlyCollection<User> Users { get; private set; }
    }
}
