using BoardgameSystem.Models;

namespace BoardgameSystem.Dtos.Requests;
//To make a Game Update Request, we need to have values below
public class UpdateGameRequestDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int AveragePlayTime { get; set; }
    public int PlayerCountMin { get; set; }
    public int PlayerCountMax { get; set; }
    public int Price { get; set; }

    public int DeveloperName { get; set; }
    public int ArtistName { get; set; }
    public int PublisherName { get; set; }
}
