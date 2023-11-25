using AutoMapper;
using BoardgameSystem.Dtos.Requests;
using BoardgameSystem.Dtos.Responses;
using BoardgameSystem.Models.ReturnModels;
using BoardgameSystem.Repositories.Abstract;
using BoardgameSystem.Services.Abstract;
using BoardgameSystem.Models;
using BoardgameSystem.Exceptions;
using Azure;

namespace BoardgameSystem.Services.Concrete;

public class GameService : IGameService
{
    public IGameRepository _gameRepository;
    //Why we use IMapper instead of Automapper?
    //Because Automapper doesn't support generic types
    //So we use IMapper
    //https://github.com/AutoMapper/AutoMapper
    //Thanks
    public IMapper _mapper;


    public GameService(IGameRepository gameRepository, IMapper mapper)
    {
        _gameRepository = gameRepository;
        _mapper = mapper;      
    }

    public ReturnModel<GameResponseDto> Add(CreateGameRequestDto gameRequestDto)
    {
        //Map values of coming request from Service Layer
        Game game = _mapper.Map<Game>(gameRequestDto);
        game.Id = _gameRepository.GetAll().Count + 1; //What is this
        _gameRepository.Add(game);

        GameResponseDto gameResponseDto = _mapper.Map<GameResponseDto>(game);

        ReturnModel<GameResponseDto> result = new ReturnModel<GameResponseDto>()
        {
            Data = gameResponseDto,
            Message = "Ekleme islemi basarili",
            StatusCode = System.Net.HttpStatusCode.Created
        };

        return result;
        /*

        //Check for already existence
        try
        {
            // Check if the game already exists in the database
            if (_gameRepository.GetById(game.Id) is not null)
            {
                // Handle the case when the game already exists
                return new ReturnModel<GameResponseDto>()
                {
                    Data = null,
                    Message = "Oyun sistemde bulunuyor",
                    StatusCode = System.Net.HttpStatusCode.Conflict
                };
            }
            else
            {
                // Add the game to the database
                _gameRepository.Add(game);

                // Map the game to a response DTO
                GameResponseDto gameResponseDto = _mapper.Map<GameResponseDto>(game);

                // Return the success response
                return new ReturnModel<GameResponseDto>()
                {
                    Data = gameResponseDto,
                    Message = "Ekleme islemi basarili",
                    StatusCode = System.Net.HttpStatusCode.Created
                };
            }
        }
        catch (Exception ex)
        {
            // Handle any exceptions that occur during the process
            return new ReturnModel<GameResponseDto>()
            {
                Data = null,
                Message = "Bir hata olustu",
                StatusCode = System.Net.HttpStatusCode.InternalServerError
            };
        }
        */
    }

    public ReturnModel<GameResponseDto> Delete(int id)
    {
        try
        {
            var game = _gameRepository.GetById(id);

            _gameRepository.Delete(id);

            var response = _mapper.Map<GameResponseDto>(game);

            return new ReturnModel<GameResponseDto>()
            {
                Data = response,
                Message = $"Id si : {id} olan oyun silindi",
                StatusCode = System.Net.HttpStatusCode.OK
            };

        }
        catch (NotFoundException ex)
        {
            {
                return new ReturnModel<GameResponseDto>()
                {
                    Message = ex.Message,
                    StatusCode = System.Net.HttpStatusCode.NotFound
                };

            }
        }

    }

    public ReturnModel<GameResponseDto> GetById(int id)
    {
        try
        {
            var game = _gameRepository.GetById(id);

            var response = _mapper.Map<GameResponseDto>(game);

            return new ReturnModel<GameResponseDto>()
            {
                Data = response,
                Message = $"The given Id field is found ({id})",
                StatusCode = System.Net.HttpStatusCode.Found
            };

        }
        catch (NotFoundException ex)
        {
            {
                return new ReturnModel<GameResponseDto>()
                {
                    Data = null,
                    Message = $"The given Id field ({id}) does not exists",
                    StatusCode = System.Net.HttpStatusCode.NotFound
                };

            }
        }
    }

    public ReturnModel<List<GameResponseDto>> GetList()
    {
        var list = _gameRepository.GetAll();
        List<GameResponseDto> response = _mapper.Map<List<GameResponseDto>>(list);

        return new ReturnModel<List<GameResponseDto>>()
        {
            Data = response,
            Message = "Oyuncular listelendi",
            StatusCode = System.Net.HttpStatusCode.OK
        };

        //try
        //{
        //    List<Game> games = _gameRepository.GetAll();

        //    var response = _mapper.Map<List<GameResponseDto>>(games);

        //    return new ReturnModel<List<GameResponseDto>>()
        //    {
        //        Data = response,
        //        Message = $"All fields fetched",
        //        StatusCode = System.Net.HttpStatusCode.Found
        //    };

        //}
        //catch (NotFoundException ex)
        //{
        //    {
        //        return new ReturnModel<List<GameResponseDto>>()
        //        {
        //            Data = null,
        //            Message = $"Something went wrong",
        //            StatusCode = System.Net.HttpStatusCode.NotFound
        //        };

        //    }
        //}
    }

    public ReturnModel<GameResponseDto> Update(UpdateGameRequestDto gameRequestDto)
    {
        try
        {
            //var game = _gameRepository.GetById(gameRequestDto.Id);

            var newGame = _mapper.Map<Game>(gameRequestDto);

            _gameRepository.Update(newGame);

            var response = _mapper.Map<GameResponseDto>(newGame);

            return new ReturnModel<GameResponseDto>()
            {
                Data = response,
                Message = $"The given Id field ({gameRequestDto.Id}) is updated",
                StatusCode = System.Net.HttpStatusCode.OK
            };

        }
        catch (NotFoundException ex)
        {
            {
                return new ReturnModel<GameResponseDto>()
                {
                    Data = null,
                    Message = $"The given Id field ({gameRequestDto.Id}) does not exists",
                    StatusCode = System.Net.HttpStatusCode.NotFound
                };
            }
        }
    }
}
