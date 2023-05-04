namespace TrashTrack.Core
{
    public class UserVehicle : BaseEntity
    {
        public DateTime PickUp { get; set; }
        public DateTime Return { get; set; }

        public int VehicleId { get; set; }
        public Vehicle Vehicle { get; set; } = null!;

        public int UserId { get; set; }
        public User Driver { get; set; } = null!;

        public ICollection<Schedule> Schedules { get; set; } = null!;
    }
}
