namespace BoardgameSystem.Models;

public class Developer
{
    public int Id { get; set; }
    public string Name { get; set; }

    public List<int> GamesDevelopedId { get; set; }
    public List<Game> GamesDeveloped { get; set; }
}
