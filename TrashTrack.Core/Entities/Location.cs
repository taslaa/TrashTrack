namespace TrashTrack.Core
{
    public class Location : BaseEntity
    {
        public string Name { get; set; } = null!;
        public string Address { get; set; } = null!;
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }

        public ICollection<Garbage> Garbages { get; set; } = null!;
    }
}
