﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using TrashTrack.Core;

namespace TrashTrack.Infrastructure
{
    public abstract class BaseConfiguration<TEntity> : IEntityTypeConfiguration<TEntity> where TEntity : BaseEntity
    {
        public virtual void Configure(EntityTypeBuilder<TEntity> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.IsDeleted)
                   .IsRequired()
                   .HasDefaultValue(false);

            builder.Property(e => e.CreatedAt)
                   .IsRequired();

            builder.Property(e => e.ModifiedAt)
                   .IsRequired(false);

            builder.HasQueryFilter(e => !e.IsDeleted);
        }
    }
}
