using Microsoft.EntityFrameworkCore.Metadata.Builders;

using TrashTrack.Core;

namespace TrashTrack.Infrastructure
{
    public class PhotoConfiguration : BaseConfiguration<Photo>
    {
        public override void Configure(EntityTypeBuilder<Photo> builder)
        {
            base.Configure(builder);

            builder.Property(e => e.Data)
                   .IsRequired();

            builder.Property(e => e.ContentType)
                   .IsRequired();

            builder.HasOne(e => e.Garbage)
                   .WithMany(e => e.Photos)
                   .HasForeignKey(e => e.GarbageId)
                   .IsRequired();
        }
    }
}
