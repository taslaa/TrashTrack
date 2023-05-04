namespace TrashTrack.Core
{
    public class Photo : BaseEntity
    {
        public byte[] Data { get; set; } = null!;
        public string ContentType { get; set; } = null!;

        public int? GarbageId { get; set; }
        public Garbage? Garbage { get; set; }

        public ICollection<User> Users { get; set; } = null!;
    }
}
