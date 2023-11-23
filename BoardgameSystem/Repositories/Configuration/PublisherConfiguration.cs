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
            builder.Property(p => p.Id).HasColumnName("PublisherID");
            builder.Property(p => p.Name).HasColumnName("PublisherName");

        }
    }
}
