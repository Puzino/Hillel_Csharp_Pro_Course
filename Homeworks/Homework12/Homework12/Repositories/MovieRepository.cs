using Homework12.Data;
using Homework12.Models;
using Homework12.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Homework12.Repositories;

public class MovieRepository : IMovieRepository
{
    private readonly AppDbContext _context;

    public MovieRepository(AppDbContext context)
    {
        _context = context;
    }

    public Movie GetMovie(int id)
    {
        return _context.Movies.Include(s => s.Sessions).FirstOrDefault(x => x.Id == id);
    }

    public List<Movie> GetMovies()
    {
        var movies = _context.Movies.Include(m => m.Sessions).ToList();
        return movies;
    }

    public void AddToMovie(Movie movie)
    {
        _context.Movies.Add(movie);
        _context.SaveChanges();
    }

    public void DeleteMovie(int id)
    {
        var mov = _context.Movies.FirstOrDefault(p => p.Id == id);
        if (mov != null)
        {
            _context.Movies.Remove(mov);
            _context.SaveChanges();
        }
    }

    public Movie EditMovie(Movie movie)
    {
        var mov = _context.Movies.FirstOrDefault(p => p.Id == movie.Id);
        if (mov != null)
        {
            mov.MovieName = movie.MovieName;
            mov.Director = movie.Director;
            mov.Style = movie.Style;
            mov.Description = movie.Description;
            _context.SaveChanges();
        }

        return mov;
    }
}