namespace BoardgameSystem.Models;

public class Artist
{
    public int Id { get; set; }
    public string Name { get; set; }

    public List<Game> GamesArtisted { get; set; }

}
