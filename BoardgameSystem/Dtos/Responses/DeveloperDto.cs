using BoardgameSystem.Models;

namespace BoardgameSystem.Dtos.Responses
{
    public class DeveloperDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Developer Developer { get; set; }
        public List<Game> Games { get; set; }

    }
}
