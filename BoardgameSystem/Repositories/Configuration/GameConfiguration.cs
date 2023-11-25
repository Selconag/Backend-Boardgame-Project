using BoardgameSystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BoardgameSystem.Repositories.Configuration
{
    public class GameConfiguration : IEntityTypeConfiguration<Game>
    {
        public void Configure(EntityTypeBuilder<Game> builder)
        {
            builder.ToTable("Games").HasKey(g => g.Id);
            builder.Property(g => g.Id).HasColumnName("GameID");
            builder.Property(g => g.Name).HasColumnName("Name");
            builder.Property(g => g.PlayerCountMin).HasColumnName("PlayerCountMin");
            builder.Property(g => g.PlayerCountMax).HasColumnName("PlayerCountMax");
            builder.Property(g => g.AveragePlayTime).HasColumnName("AveragePlaytime");
            builder.Property(g => g.Price).HasColumnName("Price");

            builder.Property(d => d.DeveloperId).HasColumnName("DeveloperID");
            builder.Property(a => a.ArtistId).HasColumnName("ArtistID");
            builder.Property(p => p.PublisherId).HasColumnName("PublisherID");
            ////1)List<Expansion> tipinin yazımının özel bir yöntemi var mı?
            ////2)Tipi çektinten sonra başka ek işlem var mı? Çünkü 1 değil 1 den fazla olabiliyor.
            //builder.Property(g => g.ExpansionIds).HasColumnName("expansion_ids");


            builder.HasOne(c => c.Developer);
            builder.HasOne(c => c.Artist);
            builder.HasOne(c => c.Publisher);

            //builder.HasMany(c => c.Expansions);

            //builder.HasData(
            //    new Game
            //    {
            //        Id = 1,
            //        Name = "Catan",
            //        PlayerCountMin = 3,
            //        PlayerCountMax = 4,
            //        AveragePlayTime = 90,
            //        Price = 279,
            //        DeveloperId = 1,
            //        ArtistId = 1,
            //        PublisherId = 1
            //    });

        }
    }
}
