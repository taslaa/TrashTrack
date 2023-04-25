namespace TrashTrack.Core
{
    public class Photo : BaseEntity
    {
        public byte[] Data { get; set; } = null!;
        public string ContentType { get; set; } = null!;

        public int? VenueId { get; set; }
        public Venue? Venue { get; set; }

        public ICollection<User> Users { get; set; } = null!;
        public ICollection<Performer> Performers { get; set; } = null!;
    }
}
