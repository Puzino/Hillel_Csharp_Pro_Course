using Homework12.Data;
using Homework12.Models;
using Homework12.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Homework12.Repositories;

public class SessionRepository : ISessionRepository
{
    private readonly AppDbContext _context;

    public SessionRepository(AppDbContext context)
    {
        _context = context;
    }

    public List<Session> GetAll()
    {
        return _context.Sessions.Include(x => x.Movie).ToList();
    }

    public Session GetById(int id)
    {
        return _context.Sessions.Include(x => x.Movie).FirstOrDefault(x => x.Id == id);
    }

    public void AddSession(Session session)
    {
        _context.Sessions.Add(session);
        _context.SaveChanges();
    }

    public void Delete(int id)
    {
        var ses = _context.Sessions.FirstOrDefault(x => x.Id == id);
        if (ses != null)
        {
            _context.Sessions.Remove(ses);
            _context.SaveChanges();
        }
    }

    public Session Edit(Session session)
    {
        var ses = _context.Sessions.FirstOrDefault(p => p.Id == session.Id);
        if (ses != null)
        {
            ses.Room = session.Room;
            ses.Price = session.Price;
            ses.DateTime = session.DateTime;
            ses.MovieId = session.MovieId;
            ses.Movie = session.Movie;
            _context.SaveChanges();
        }

        return ses;
    }
}