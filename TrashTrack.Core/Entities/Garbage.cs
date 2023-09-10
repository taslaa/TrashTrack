namespace TrashTrack.Core
{
    public class Garbage : BaseEntity
    {
        public string Description { get; set; } = null!;
        public GarbageType GarbageType { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }

        public ICollection<Photo>? Photos { get; set; }
        public ICollection<Schedule> Schedules { get; set; } = null!;
    }
}
