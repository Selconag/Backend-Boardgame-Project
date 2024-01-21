using BoardgameSystem.Dtos.Responses;
using BoardgameSystem.Models;
using BoardgameSystem.Models.ReturnModels;
using BoardgameSystem.Dtos;
using BoardgameSystem.Dtos.Requests;

namespace BoardgameSystem.Services.Abstract;

public interface IGameService
{
    ReturnModel<List<GetGameRequestDto>> GetList();
    ReturnModel<GetGameRequestDto> GetById(int id);
    ReturnModel<GameResponseDto> Add(AddGameRequestDto gameRequestDto);
    ReturnModel<GameResponseDto> Update(UpdateGameRequestDto gameRequestDto);
    ReturnModel<GameResponseDto> Delete(int id);
}
