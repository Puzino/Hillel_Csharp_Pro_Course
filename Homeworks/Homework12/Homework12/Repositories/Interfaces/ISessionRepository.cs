using Homework12.Models;

namespace Homework12.Repositories.Interfaces;

public interface ISessionRepository
{
    List<Session> GetAll();

    Session GetById(int id);

    void AddSession(Session session);

    void Delete(int id);

    public Session Edit(Session session);
}