using Homework12.Models;
using Homework12.Repositories.Interfaces;
using Homework12.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Homework12.Controllers;

public class MovieController : Controller
{
    private readonly IMovieRepository _movieRepository;

    public MovieController(IMovieRepository movieRepository)
    {
        _movieRepository = movieRepository;
    }

    public async Task<IActionResult> Index()
    {
        return View(_movieRepository.GetMovies());
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(MovieViewModel movieVM)
    {
        if (ModelState.IsValid)
        {
            var movie = new Movie()
            {
                MovieName = movieVM.MovieName,
                Description = movieVM.Description,
                Style = movieVM.Style,
                Director = movieVM.Director
            };
            _movieRepository.AddToMovie(movie);

            return RedirectToAction("Index");
        }

        return View("Create", movieVM);
    }

    public IActionResult Edit(int id)
    {
        return View(_movieRepository.GetMovie(id));
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Edit(int id, Movie movie)
    {
        if (ModelState.IsValid)
        {
            _movieRepository.EditMovie(movie);
        }

        return RedirectToAction("Index");
    }

    public IActionResult Delete(int? id)
    {
        var movie = _movieRepository.GetMovie(id.Value);
        if (movie != null)
        {
            return View(movie);
        }

        return View("doesNotExists");
    }

    [HttpPost, ActionName("DeleteConfirmed")]
    [ValidateAntiForgeryToken]
    public IActionResult DeleteConfirmed(int id)
    {
        _movieRepository.DeleteMovie(id);

        return RedirectToAction("Index");
    }

    public IActionResult Details(int id)
    {
        var mov = _movieRepository.GetMovie(id);
        if (mov != null)
        {
            return View(mov);
        }

        return View("doesNotExists");
    }
}