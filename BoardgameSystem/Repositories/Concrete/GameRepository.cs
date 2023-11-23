using BoardgameSystem.Context;
using BoardgameSystem.Models;
using BoardgameSystem.Repositories.Abstract;
using BoardgameSystem.Exceptions;
using System.Data.Entity;

namespace BoardgameSystem.Repositories.Concrete;

public class GameRepository : IGameRepository
{
    private readonly BaseDbContext _context;

    public GameRepository(BaseDbContext context)
    {
        //Implement elements that is required at start
        _context = context;
    }

    public void Add(Game game)
    {
        _context.Games.Add(game);
        _context.SaveChanges();
    }

    public void Delete(int id)
    {
        var game = _context.Games.Find(id);
        if (game is null)
        {
            throw new NotFoundException(id);
        }
        _context.Games.Remove(game);
        _context.SaveChanges();
    }

    //We can access all information using only games
    public List<Game> GetAll()
    {
        return _context.Games
            .Include(g=> g.Artist)
            .Include(g => g.Publisher)
            .Include(g => g.Developer)
            .ToList();
    }

    public Game GetById(int id)
    {
        var game = _context.Games.Find(id);
        if (game is null)
        {
            throw new NotFoundException(id);
        }
        return game;
    }

    public void Update(Game game)
    {
        var gametoUpdate = _context.Games.Find(game.Id);
        if (gametoUpdate is null)
        {
            throw new NotFoundException(game.Id);
        }
        _context.Games.Update(game);
        _context.SaveChanges();
    }
}
