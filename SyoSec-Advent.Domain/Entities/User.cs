using SyoSec_Advent.Domain.ValueObject;

namespace SyoSec_Advent.Domain.Entities
{
    public class User : Entity
    {
        private List<Role> _roles = new();
        private User()
        {
            
        }
        public User(Name fullName, string userName, string passwordHash)
        {
            FullName = fullName;
            UserName = userName;
            PasswordHash = passwordHash;
        }

        public Name FullName { get; private set; }
        public string UserName { get; private set; }
        public string PasswordHash { get; private set; }
        public IReadOnlyCollection<Role> Roles { get => _roles;}

        public void AddRole(Role role) => _roles.Add(role); 

        public void UpdateUser(Name fullName, string userName, string password)
        {
            FullName = fullName; 
            UserName = userName;
            PasswordHash = password;
        }
        //Alterar Passaword
        //Recuperar a Password

    }
}
