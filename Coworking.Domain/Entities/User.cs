using Coworking.Domain.Commons;
using Coworking.Domain.Enums;

namespace Coworking.Domain.Entities
{
    public class User : Auditable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string GroupName { get; set; }
        public UserRole Role { get; set; }

        public long CoworkingId { get; set; }
        public Coworkingg Coworking { get; set; }
    }
}
