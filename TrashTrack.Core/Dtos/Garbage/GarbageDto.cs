namespace TrashTrack.Core
{
    public class GarbageDto : BaseDto
    {
        public string Description { get; set; } = null!;
        public GarbageType GarbageType { get; set; }

        public int LocationId { get; set; }
        public LocationDto Location { get; set; } = null!;
    }
}
