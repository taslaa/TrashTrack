namespace TrashTrack.Core
{
    public class Schedule : BaseEntity
    {
        public DateTime PickupDate { get; set; }
        public PickupStatus Status { get; set; }

        public int GarbageId { get; set; }
        public Garbage Garbage { get; set; } = null!;

        public int UserVehicleId { get; set; }
        public UserVehicle UserVehicle { get; set; } = null!;
    }
}
