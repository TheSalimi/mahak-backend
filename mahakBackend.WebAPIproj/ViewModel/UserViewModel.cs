using mahakBackend.Core.Domain.entities;

namespace mahakBackend.WebAPIproj.ViewModel
{
    public class UserViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string? UserCode { get; set; }
        public DateTime? LastActivity { get; set; }
        public DateTime? JoinDate { get; set; }
        public string? Group { get; set; }
        public string? Description { get; set; }
        public bool isAdded { get; set; }
        public int? imageId { get; set; }
        public string phoneNumber { get; set; }

        public static UserViewModel mapEntityToModel(UserEntity user)
        {
            UserViewModel newUser = new UserViewModel();
            newUser.Id = user.Id;
            newUser.Name = user.Name;
            newUser.Email = user.Email;
            newUser.UserCode = user.UserCode;
            newUser.phoneNumber = user.phoneNumber.Substring(0, 4) + "***" + user.phoneNumber.Substring(7);
            newUser.Description = user.Description;
            newUser.Group = user.Group;
            newUser.isAdded = user.isAdded;
            newUser.LastActivity = user.LastActivity;
            newUser.JoinDate = user.JoinDate;
            newUser.imageId = user.imageId;

            return newUser;
        }
    }
}
