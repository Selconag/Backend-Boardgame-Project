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
        public int Price { get; set; }
        public Developer Developer { get; set; }
        public Artist Artist { get; set; }
        public Publisher Publisher { get; set; }
        //public List<Expansion> Expansions { get; set; }

    }
}
