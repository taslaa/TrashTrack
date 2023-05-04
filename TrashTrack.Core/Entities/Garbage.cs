namespace TrashTrack.Core
{
    public class Garbage : BaseEntity
    {
        public string Description { get; set; } = null!;
        public GarbageType GarbageType { get; set; }

        public int LocationId { get; set; }
        public Location Location { get; set; } = null!;

        public ICollection<Photo>? Photos { get; set; }
        public ICollection<Schedule> Schedules { get; set; } = null!;
    }
}
