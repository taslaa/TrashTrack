using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TrashTrack.Core;

namespace TrashTrack.Infrastructure
{
    public class UserVehicleConfiguration : BaseConfiguration<UserVehicle>
    {
        public override void Configure(EntityTypeBuilder<UserVehicle> builder)
        {
            base.Configure(builder);

            builder.Property(e => e.PickUp)
                   .IsRequired();

            builder.Property(e => e.Return)
                   .IsRequired();

            builder.HasOne(e => e.Vehicle)
                   .WithMany(e => e.UserVehicles)
                   .HasForeignKey(e => e.VehicleId)
                   .IsRequired();

            builder.HasOne(e => e.Driver)
                 .WithMany(e => e.UserVehicles)
                 .HasForeignKey(e => e.UserId)
                 .IsRequired();
        }
    }
}
