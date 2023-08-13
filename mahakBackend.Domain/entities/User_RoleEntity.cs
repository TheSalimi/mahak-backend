using System.Data;

namespace mahakBackend.Core.Domain.entities
{
    public class User_RoleEntity
    {
        public int Id { get; set; }
        public int RoleId { get; set; }
        public int UserId { get; set; }

        public RoleEntity Role { get; set; }
        public UserEntity User { get; set; }
    }
}
