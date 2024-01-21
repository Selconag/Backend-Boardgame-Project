namespace BoardgameSystem.Profiles;
using BoardgameSystem.Models;
using BoardgameSystem.Dtos.Responses;
using BoardgameSystem.Dtos.Requests;
using AutoMapper;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<AddGameRequestDto, Game>();
        CreateMap<UpdateGameRequestDto, Game>();
        CreateMap<Game, GameResponseDto>();

        CreateMap<Developer, DeveloperDto>();
        CreateMap<Artist, ArtistDto>();
        CreateMap<Publisher, PublisherDto>();

        CreateMap<AddGameRequestDto, GetGameRequestDto>();
        CreateMap<UpdateGameRequestDto, GetGameRequestDto>();
        CreateMap<Game, GetGameRequestDto>();
        CreateMap<GameResponseDto, GetGameRequestDto>();
    }
}
