namespace TrashTrack.Core
{
    public class Schedule : BaseEntity
    {
        public DateTime PickupDate { get; set; }
        public PickupStatus Status { get; set; }

        public int GarbageId { get; set; }
        public Garbage Garbage { get; set; } = null!;

        public int VehicleId { get; set; }
        public Vehicle Vehicle { get; set; } = null!;

        public int UserId { get; set; }
        public User Driver { get; set; } = null!;
    }
}
