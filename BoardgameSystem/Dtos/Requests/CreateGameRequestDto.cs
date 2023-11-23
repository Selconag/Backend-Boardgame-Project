namespace BoardgameSystem.Dtos.Requests;

//To make a new Game Creation Request, we need to create a new DTO with variables below
public class CreateGameRequestDto
{
    public string Name { get; set; }
    public int AveragePlayTime { get; set; }
    public int PlayerCountMin { get; set; }
    public int PlayerCountMax { get; set; }
    public int Price { get; set; }

    public int DeveloperName { get; set; }
    public int ArtistName { get; set; }
    public int PublisherName { get; set; }
}
