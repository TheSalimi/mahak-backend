namespace mahakBackend.Core.Domain.entities
{
    public class RoleEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? ColorId { get; set; }
        public int? IconId { get; set; }

        public ICollection<User_RoleEntity> UserRoles { get; set; }
    }
}
