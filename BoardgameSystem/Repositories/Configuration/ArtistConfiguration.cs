using BoardgameSystem.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace BoardgameSystem.Repositories.Configuration
{
    public class ArtistConfiguration : IEntityTypeConfiguration<Artist>
    {
        public void Configure(EntityTypeBuilder<Artist> builder)
        {
            builder.ToTable("Artists").HasKey(c => c.Id);
            builder.Property(c => c.Id).HasColumnName("ArtistID");
            builder.Property(c => c.Name).HasColumnName("Name");

        }
    }
}
