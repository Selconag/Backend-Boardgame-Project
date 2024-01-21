using BoardgameSystem.Repositories.Abstract;
using System.Linq;
using Exceptions;
namespace BoardgameSystem.Services.BusinessRules.Concrete;
public class GameRules
{
    private readonly IGameRepository _gameRepository;

    public GameRules(IGameRepository gameRepository)
    {
        _gameRepository = gameRepository;
    }


    public void CategoryNameMustBeUnique(string categoryName)
    {
        //var category = _gameRepository.GetByFilter(x => x.Name == categoryName);
        //if (category != null)
        //{
        //    //throw new BusinessException("Kategori adı benzersiz olmalı.");
        //}

    }


    public void CategoryIsPresent(int id)
    {
        var category = _gameRepository.GetById(id);
        if (category == null)
        {
            throw new BusinessException($"Id : {id} olan kategori bulunamadı.");
        }

    }
}
