using BoardgameSystem.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace BoardgameSystem.Repositories.Configuration
{
    public class DeveloperConfiguration : IEntityTypeConfiguration<Developer>
    {
        public void Configure(EntityTypeBuilder<Developer> builder)
        {
            builder.ToTable("Developers").HasKey(d => d.Id);
            builder.Property(d => d.Id).HasColumnName("DeveloperID");
            builder.Property(d => d.Name).HasColumnName("Name");
            //builder.Property(d => d.GamesDeveloped).HasColumnName("developer_gamesdeveloped");

        }
    }
}
