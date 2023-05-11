using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TrashTrack.Core;

namespace TrashTrack.Infrastructure
{
    public class ScheduleConfiguration : BaseConfiguration<Schedule>
    {
        public override void Configure(EntityTypeBuilder<Schedule> builder)
        {
            base.Configure(builder);

            builder.Property(e => e.PickupDate)
                   .IsRequired();

            builder.Property(e => e.Status)
                   .IsRequired();

            builder.HasOne(e => e.Garbage)
                   .WithMany(e => e.Schedules)
                   .HasForeignKey(e => e.GarbageId)
                   .IsRequired();

            builder.HasOne(e => e.UserVehicle)
                   .WithMany(e => e.Schedules)
                   .HasForeignKey(e => e.UserVehicleId)
                   .IsRequired();
        }
    }
}
