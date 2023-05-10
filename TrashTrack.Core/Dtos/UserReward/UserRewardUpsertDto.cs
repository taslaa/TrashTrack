namespace TrashTrack.Core
{
    public class UserRewardUpsertDto : BaseDto
    {
        public DateTime DateEarned { get; set; }

        public int UserId { get; set; }

        public int RewardId { get; set; }
    }
}
