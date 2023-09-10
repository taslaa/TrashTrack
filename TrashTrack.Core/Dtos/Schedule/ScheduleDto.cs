namespace TrashTrack.Core
{
    public class ScheduleDto : BaseDto
    {
        public DateTime PickupDate { get; set; }
        public PickupStatus Status { get; set; }

        public int GarbageId { get; set; }
        public GarbageDto Garbage { get; set; } = null!;

        public int VehicleId { get; set; }
        public VehicleDto Vehicle { get; set; } = null!;

        public int UserId { get; set; }
        public UserDto Driver { get; set; } = null!;
    }
}
