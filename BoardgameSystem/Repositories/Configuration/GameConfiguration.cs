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
            builder.Property(g => g.Id).HasColumnName("game_id");
            builder.Property(g => g.Name).HasColumnName("game_name");
            builder.Property(g => g.PlayerCountMin).HasColumnName("game_playercountmin");
            builder.Property(g => g.PlayerCountMax).HasColumnName("game_playercountmax");
            builder.Property(g => g.AveragePlayTime).HasColumnName("game_averageplaytime");
            builder.Property(g => g.Price).HasColumnName("game_price");

            builder.Property(g => g.DeveloperId).HasColumnName("developer_id");
            builder.Property(g => g.ArtistId).HasColumnName("artist_id");
            builder.Property(g => g.PublisherId).HasColumnName("publisher_id");

            ////1)List<Expansion> tipinin yazımının özel bir yöntemi var mı?
            ////2)Tipi çektinten sonra başka ek işlem var mı? Çünkü 1 değil 1 den fazla olabiliyor.
            //builder.Property(g => g.ExpansionIds).HasColumnName("expansion_ids");


            builder.HasOne(c => c.Developer);
            builder.HasOne(c => c.Artist);
            builder.HasOne(c => c.Publisher);

            builder.HasMany(c => c.Expansions);

            builder.HasData(
                new Game
                {
                    Id = 1,
                    Name = "Catan",
                    PlayerCountMin = 3,
                    PlayerCountMax = 4,
                    AveragePlayTime = 90,
                    Price = 279,
                    DeveloperId = 1,
                    ArtistId = 1,
                    PublisherId = 1
                });

        }
    }
}
