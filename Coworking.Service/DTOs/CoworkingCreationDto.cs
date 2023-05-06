namespace Coworking.Service.DTOs
{
    public class CoworkingCreationDto
    {
        public int Floor { get; set; }
        public int Table { get; set; }
        public int Chair { get; set; }
        public DateTime StartAt { get; set; }
        public DateTime? EndAt { get; set; }
    }
}
