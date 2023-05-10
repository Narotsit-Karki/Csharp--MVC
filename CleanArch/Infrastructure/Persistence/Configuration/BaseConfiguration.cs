using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configuration
{
    public abstract class BaseConfiguration<T>: IEntityTypeConfiguration<T> where T:
        BaseEntity
    {
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            builder.HasKey(h => h.Id);
            builder.Property(p => p.Id).IsRequired().UseIdentityColumn(1,1).ValueGeneratedOnAdd();
            builder.Property(p => p.IsActive).IsRequired();
            builder.Property(p => p.LastUpdatedAt).IsRequired();
            builder.Property(p => p.LastUpdatedBy).IsRequired().HasMaxLength(200);
        }
    }
    // Ddata Context
}
