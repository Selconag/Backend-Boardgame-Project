using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using BoardgameSystem.Models;

namespace BoardgameSystem.Repositories.Configuration
{
    public class ExpansionsConfiguration : IEntityTypeConfiguration<Expansion>
    {
        public void Configure(EntityTypeBuilder<Expansion> builder)
        {
            builder.ToTable("Expansion_db").HasKey(e => e.Id);
            builder.Property(e => e.Id).HasColumnName("Expansion_id");
            builder.Property(e => e.Id).HasColumnName("Expansion_name");
            builder.Property(e => e.Name).IsRequired().HasMaxLength(50);

            builder.HasOne(c=>c.Developer);
            builder.HasOne(c=>c.Artist);
            builder.HasOne(c=>c.Publisher);
        }
    }
}
