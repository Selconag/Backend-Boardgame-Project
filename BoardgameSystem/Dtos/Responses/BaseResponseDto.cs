using BoardgameSystem.Models;

namespace BoardgameSystem.Dtos.Responses
{
    public class BaseResponseDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Developer Developer { get; set; }
        public Artist Artist { get; set; }
        public Publisher Publisher { get; set; }
        public List<Expansion> Expansions { get; set; }

    }
}
