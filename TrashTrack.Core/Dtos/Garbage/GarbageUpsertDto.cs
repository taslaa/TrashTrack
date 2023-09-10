namespace TrashTrack.Core
{
    public class GarbageUpsertDto : BaseUpsertDto
    {
        public string Description { get; set; } = null!;
        public GarbageType GarbageType { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
    }
}
