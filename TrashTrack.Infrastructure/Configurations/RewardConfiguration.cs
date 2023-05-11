using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TrashTrack.Core;

namespace TrashTrack.Infrastructure.Configurations
{
    public class RewardConfiguration : BaseConfiguration<Reward>
    {
        public override void Configure(EntityTypeBuilder<Reward> builder)
        {
            base.Configure(builder);

            builder.Property(e => e.Name)
                   .IsRequired();

            builder.Property(e => e.Description)
                   .IsRequired();

            builder.Property(e => e.PointValue)
                   .IsRequired();
        }
    }
}
