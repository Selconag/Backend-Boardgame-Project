namespace Service.UnitTest.Test_Games;
using System.Net;
using BoardgameSystem.Services;
using BoardgameSystem.Services.Abstract;
using BoardgameSystem.Services.Concrete;
using Moq;
using BoardgameSystem.Models;
using BoardgameSystem.Dtos.Responses;
using BoardgameSystem.Dtos.Requests;
using BoardgameSystem.Repositories.Abstract;
using AutoMapper;

public class GameServiceTests
{
    GameService _service;
    Mock<IGameRepository> _mockGameRepository = new Mock<IGameRepository>();
    //Add Rules Later

    Game game;
    GameResponseDto gameResponseDto;
    AddGameRequestDto gameAddRequest;
    UpdateGameRequestDto gameUpdateRequest;


    [SetUp]
    public void Setup()
    {
        _mockGameRepository = new Mock<IGameRepository>();
        _service = new GameService(_mockGameRepository.Object, null);
        gameAddRequest = new AddGameRequestDto { Name = "Splendor", PlayerCountMin = 2, PlayerCountMax = 4, AveragePlayTime = 60, Price = 60, DeveloperID = 1, ArtistID = 1, PublisherID = 1 };
        gameUpdateRequest = new UpdateGameRequestDto { Id = 3, Name = "Splendor", PlayerCountMin = 2, PlayerCountMax = 4, AveragePlayTime = 60, Price = 60, DeveloperID = 2, ArtistID = 2, PublisherID = 2 };
        game = new Game 
        {
            //Terraforming mars
            Id = 4,
            Name = "Terraforming Mars",
            PlayerCountMin = 2,
            PlayerCountMax = 4,
            AveragePlayTime = 120,
            Price = 240,
            DeveloperId = 3,
            Developer = new Developer(),
            ArtistId = 3,
            Artist = new Artist(),
            PublisherId = 3,
            Publisher = new Publisher()
        };

        gameResponseDto = new GameResponseDto { Id = 3, Name = "Splendor", PlayerCountMin = 2, PlayerCountMax = 4, AveragePlayTime = 60, Price = 60, Developer = new DeveloperDto(), Artist = new ArtistDto(), Publisher = new PublisherDto() };

    }

    //[Test]
    //public void Add_WhenGameNameIsUnique_ReturnsOk()
    //{
    //    //Arrange
    //    _mockRules.Setup(x => x.ProductNameMustBeUnique(productAddRequest.Name));
    //    _mockRepository.Setup(x => x.Add(game));

    //    //Act
    //    var result = _service.Add(productAddRequest);

    //    //Assert
    //    Assert.AreEqual(result.StatusCode, HttpStatusCode.Created);
    //    Assert.AreEqual(result.Data, productResponseDto);
    //    Assert.AreEqual(result.Message, "Ürün Eklendi");

    //    Assert.Pass();
    //}
}