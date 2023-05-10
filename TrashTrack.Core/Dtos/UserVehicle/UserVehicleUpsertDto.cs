namespace TrashTrack.Core
{
    public class UserVehicleUpsertDto : BaseUpsertDto
    {
        public DateTime PickUp { get; set; }
        public DateTime Return { get; set; }

        public int VehicleId { get; set; }

        public int UserId { get; set; }
    }
}
