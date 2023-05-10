using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TrashTrack.Core;

namespace TrashTrack.Infrastructure.Configurations
{
    public class GarbageConfiguration : BaseConfiguration<Garbage>
    {
        public override void Configure(EntityTypeBuilder<Garbage> builder)
        {
            base.Configure(builder);

            builder.Property(e => e.Description)
                   .IsRequired();

            builder.Property(e => e.GarbageType)
                   .IsRequired();

            builder.HasOne(e => e.Location)
                   .WithMany(e => e.Garbages)
                   .HasForeignKey(e => e.LocationId)
                   .IsRequired();
        }
    }
}
