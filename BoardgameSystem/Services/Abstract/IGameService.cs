using BoardgameSystem.Dtos.Responses;
using BoardgameSystem.Models;
using BoardgameSystem.Models.ReturnModels;
using BoardgameSystem.Dtos;
using BoardgameSystem.Dtos.Requests;

namespace BoardgameSystem.Services.Abstract;

public interface IGameService
{
    ReturnModel<List<GameResponseDto>> GetList();
    ReturnModel<GameResponseDto> GetById(int id);
    ReturnModel<GameResponseDto> Add(CreateGameRequestDto gameRequestDto);
    ReturnModel<GameResponseDto> Update(UpdateGameRequestDto gameRequestDto);
    ReturnModel<GameResponseDto> Delete(int id);
}
