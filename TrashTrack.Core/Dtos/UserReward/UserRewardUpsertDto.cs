namespace TrashTrack.Core
{
    public class UserRewardUpsertDto : BaseUpsertDto
    {
        public DateTime DateEarned { get; set; }

        public int UserId { get; set; }

        public int RewardId { get; set; }
    }
}
