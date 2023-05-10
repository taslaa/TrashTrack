namespace TrashTrack.Core
{
    public class LocationDto : BaseDto
    {
        public string Name { get; set; } = null!;
        public string Address { get; set; } = null!;
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
    }
}
