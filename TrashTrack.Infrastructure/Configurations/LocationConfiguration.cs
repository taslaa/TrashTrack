using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TrashTrack.Core;

namespace TrashTrack.Infrastructure
{
    public class LocationConfiguration : BaseConfiguration<Location>
    {
        public override void Configure(EntityTypeBuilder<Location> builder)
        {
            base.Configure(builder);

            builder.Property(e => e.Name)
                   .IsRequired();

            builder.Property(e => e.Address)
                   .IsRequired();

            builder.Property(e => e.Longitude)
                   .IsRequired();

            builder.Property(e => e.Latitude)
                   .IsRequired();
        }
    }
}
