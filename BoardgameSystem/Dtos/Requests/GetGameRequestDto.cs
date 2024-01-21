namespace BoardgameSystem.Dtos.Requests
{
    public class GetGameRequestDto
    {
        public string Name { get; set; }
        public int AveragePlayTime { get; set; }
        public int PlayerCountMin { get; set; }
        public int PlayerCountMax { get; set; }
        public decimal Price { get; set; }

        public string DeveloperName { get; set; }
        public string ArtistName { get; set; }
        public string PublisherName { get; set; }
    }
}
