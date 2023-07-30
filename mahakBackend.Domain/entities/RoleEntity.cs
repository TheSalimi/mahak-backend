namespace mahakBackend.Core.Domain.entities
{
    public class RoleEntity
    {
        public int Id { get; set; }
        public long Name { get; set; }
        public string? ColorId { get; set; }
        public string? IconId { get; set; }
    }
}
