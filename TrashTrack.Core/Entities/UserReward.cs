namespace TrashTrack.Core
{
    public class UserReward : BaseEntity
    {
        public DateTime DateEarned { get; set; }

        public int UserId { get; set; }
        public User User { get; set; } = null!;

        public int RewardId { get; set; }
        public Reward Reward { get; set; } = null!;
    }
}
