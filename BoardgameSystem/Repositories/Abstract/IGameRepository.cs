using BoardgameSystem.Models;

namespace BoardgameSystem.Repositories.Abstract;

public interface IGameRepository
{
    void Add(Game game);
    void Update(Game game);
    void Delete(int id);
    Game GetById(int id);
    List<Game> GetAll();
}
