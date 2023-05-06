namespace Coworking.Service.DTOs
{
    public class CoworkingUpdateDto
    {
        public long Id { get; set; }
        public int Floor { get; set; }
        public int Table { get; set; }
        public int Chair { get; set; }
        public DateTime StartAt { get; set; }
        public DateTime? EndAt { get; set; }
    }
}
