namespace SyoSec_Advent.Domain.Entities
{
    public class Role : Entity
    {
        private Role()
        {

        }
        public Role(string roleName)
        {
            RoleName = roleName;
        }

        public string RoleName { get; private set; }
        public IReadOnlyCollection<User> Users { get; private set; } = new List<User>();
    }
}
