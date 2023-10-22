using Homework12.Models;

namespace Homework12.Repositories.Interfaces;

public interface IMovieRepository
{
    Movie GetMovie(int id);

    List<Movie> GetMovies();

    void AddToMovie(Movie movie);

    void DeleteMovie(int id);
    
    Movie EditMovie(Movie movie);
}