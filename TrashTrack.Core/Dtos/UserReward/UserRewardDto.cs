namespace TrashTrack.Core
{
    public class UserRewardDto : BaseDto
    {
        public DateTime DateEarned { get; set; }

        public int UserId { get; set; }
        public UserDto User { get; set; } = null!;

        public int RewardId { get; set; }
        public RewardDto Reward { get; set; } = null!;
    }
}
