using BoardgameSystem.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace BoardgameSystem.Repositories.Configuration
{
    public class PublisherConfiguration : IEntityTypeConfiguration<Publisher>
    {
        public void Configure(EntityTypeBuilder<Publisher> builder)
        {
            builder.ToTable("Publishers").HasKey(p => p.Id);
            builder.Property(p => p.Id).HasColumnName("publisher_id");
            builder.Property(p => p.Name).HasColumnName("publisher_name");
            builder.Property(c => c.Name).IsRequired().HasMaxLength(50);

        }
    }
}
