namespace BoardgameSystem.Models;

public class Game
{
    public int Id { get; set; }
    public string Name { get; set; }

    public int AveragePlayTime { get; set; }
    public int PlayerCountMin { get; set; }
    public int PlayerCountMax { get; set; }
    public decimal Price { get; set; }

    public int DeveloperId { get; set; }
    public Developer Developer { get; set; }

    public int ArtistId { get; set; }
    public Artist Artist { get; set; }

    public int PublisherId { get; set; }
    public Publisher Publisher { get; set; }

    //public List<int> ExpansionIds { get; set; }
    //public List<Expansion> Expansions { get; set; }
}
