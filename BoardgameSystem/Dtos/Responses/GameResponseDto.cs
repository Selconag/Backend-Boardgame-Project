using BoardgameSystem.Models;

namespace BoardgameSystem.Dtos.Responses
{
    public class GameResponseDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int AveragePlayTime { get; set; }
        public int PlayerCountMin { get; set; }
        public int PlayerCountMax { get; set; }
        public decimal Price { get; set; }
        public DeveloperDto Developer { get; set; }
        public ArtistDto Artist { get; set; }
        public PublisherDto Publisher { get; set; }
        //public List<Expansion> Expansions { get; set; }

    }
}
