using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TrashTrack.Core;

namespace TrashTrack.Infrastructure
{
    public class UserRewardConfiguration : BaseConfiguration<UserReward>
    {
        public override void Configure(EntityTypeBuilder<UserReward> builder)
        {
            base.Configure(builder);

            builder.Property(e => e.DateEarned)
                   .IsRequired();


            builder.HasOne(e => e.User)
                   .WithMany(e => e.UserRewards)
                   .HasForeignKey(e => e.UserId)
                   .IsRequired();

            builder.HasOne(e => e.Reward)
                   .WithMany(e => e.UserRewards)
                   .HasForeignKey(e => e.RewardId)
                   .IsRequired();
        }
    }
}
