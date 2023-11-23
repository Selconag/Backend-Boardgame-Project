using BoardgameSystem.Models;

namespace BoardgameSystem.Dtos.Responses
{
    public class PublisherDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Publisher Publisher { get; set; }
        public List<Game> Games { get; set; }

    }
}
