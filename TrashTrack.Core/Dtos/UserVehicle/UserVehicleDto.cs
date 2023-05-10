namespace TrashTrack.Core
{
    public class UserVehicleDto : BaseDto
    {
        public DateTime PickUp { get; set; }
        public DateTime Return { get; set; }

        public int VehicleId { get; set; }
        public VehicleDto Vehicle { get; set; } = null!;

        public int UserId { get; set; }
        public UserDto Driver { get; set; } = null!;
    }
}
