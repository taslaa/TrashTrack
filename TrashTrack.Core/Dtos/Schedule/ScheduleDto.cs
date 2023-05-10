namespace TrashTrack.Core
{
    public class ScheduleDto : BaseDto
    {
        public DateTime PickupDate { get; set; }
        public PickupStatus Status { get; set; }

        public int GarbageId { get; set; }
        public GarbageDto Garbage { get; set; } = null!;

        public int UserVehicleId { get; set; }
        public UserVehicleDto UserVehicle { get; set; } = null!;
    }
}
