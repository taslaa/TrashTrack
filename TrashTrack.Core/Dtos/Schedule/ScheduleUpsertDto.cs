namespace TrashTrack.Core
{ 
    public class ScheduleUpsertDto : BaseUpsertDto
    {
        public DateTime PickupDate { get; set; }
        public PickupStatus Status { get; set; }

        public int GarbageId { get; set; }
        
        public int VehicleId { get; set; }

        public int UserId { get; set; }
    }
}
