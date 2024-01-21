namespace BoardgameSystem.Dtos.Requests;

//To make a new Game Creation Request, we need to create a new DTO with variables below
public class AddGameRequestDto
{
    public string Name { get; set; }
    public int AveragePlayTime { get; set; }
    public int PlayerCountMin { get; set; }
    public int PlayerCountMax { get; set; }
    public decimal Price { get; set; }

    public int DeveloperID { get; set; }
    public int ArtistID { get; set; }
    public int PublisherID { get; set; }
}
