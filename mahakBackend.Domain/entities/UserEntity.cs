namespace mahakBackend.Core.Domain.entities
{
    public class UserEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public long UserCode { get; set; }
        public DateTime LastActivity { get; set; }
        public DateTime JoinDate { get; set; }
        public string? Group { get; set; }
        public string? Description { get; set; }
        public bool isAdded { get; set;}

        public ICollection<User_RoleEntity> UserRoles { get; set; }
    }

}
