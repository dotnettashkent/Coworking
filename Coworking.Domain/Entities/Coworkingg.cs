using Coworking.Domain.Commons;

namespace Coworking.Domain.Entities
{
    public class Coworkingg : Auditable
    {
        public int Floor { get; set; }
        public int Table { get; set; }
        public int Chair { get; set; }
        public DateTime StartAt { get; set; }
        public DateTime? EndAt { get; set; }

        public long UserId { get; set; }
        public User User { get; set; }
    }
}
