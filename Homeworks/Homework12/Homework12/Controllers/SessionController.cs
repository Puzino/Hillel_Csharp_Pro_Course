using Homework12.Models;
using Homework12.Repositories.Interfaces;
using Homework12.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Homework12.Controllers;

public class SessionController : Controller
{
    private readonly ISessionRepository _sessionRepository;

    public SessionController(ISessionRepository sessionRepository)
    {
        _sessionRepository = sessionRepository;
    }

    public async Task<IActionResult> Index()
    {
        return View(_sessionRepository.GetAll());
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(SessionViewModel sessionVM)
    {
        if (ModelState.IsValid)
        {
            var session = new Session()
            {
                Room = sessionVM.Room,
                Price = sessionVM.Price,
                DateTime = sessionVM.DateTime,
                MovieId = sessionVM.MovieId
            };
            _sessionRepository.AddSession(session);

            return RedirectToAction("Index");
        }

        return View("Create", sessionVM);
    }

    public IActionResult Edit(int id)
    {
        return View(_sessionRepository.GetById(id));
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Edit(int id, Session session)
    {
        if (ModelState.IsValid)
        {
            _sessionRepository.Edit(session);
        }

        return RedirectToAction("Index");
    }

    public IActionResult Delete(int? id)
    {
        var session = _sessionRepository.GetById(id.Value);
        if (session != null)
        {
            return View(session);
        }

        return View("doesNotExists");
    }

    [HttpPost, ActionName("DeleteConfirmed")]
    [ValidateAntiForgeryToken]
    public IActionResult DeleteConfirmed(int id)
    {
        _sessionRepository.Delete(id);

        return RedirectToAction("Index");
    }
}