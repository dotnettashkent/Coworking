using Coworking.Domain.Enums;

namespace Coworking.Service.DTOs
{
    public class UserResultDto
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string GroupName { get; set; }
        public UserRole Role { get; set; }
    }
}
