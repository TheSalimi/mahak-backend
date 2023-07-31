namespace mahakBackend.Core.Domain.entities
{
    public class UserEntity
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public long? UserCode { get; set; }
        public DateTime? LastActivity { get; set; }
        private DateTime _JoinDate;
        public DateTime JoinDate
        {
            get => _JoinDate.Date;
            set => _JoinDate = value.Date;
        }
        public string? Group { get; set; }
        public string? Description { get; set; }
        public bool? isAdded { get; set;}
    }
}
