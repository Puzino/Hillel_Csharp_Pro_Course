using Homework12.Models;
using Microsoft.EntityFrameworkCore;

namespace Homework12.Data;

public class DbInitializer
{
    private readonly ModelBuilder _modelBuilder;

    public DbInitializer(ModelBuilder modelBuilder)
    {
        _modelBuilder = modelBuilder;
    }

    public void Seed()
    {
        _modelBuilder.Entity<Movie>(x =>
        {
            x.HasData(
                new Movie
                {
                    Id = 1,
                    MovieName = "Rokki First blood",
                    Director = "Sylvester Stallone",
                    Style = "Fighting",
                    Description =
                        "is an American sports drama film starring Sylvester Stallone as boxer Rocky Balboa. Production was organized and overseen by producers Irwin Winkler, Robert Chartoff and their company Chartoff-Winkler Productions, and John Evildsen, who directed the film from Stallone's screenplay, was hired as director. Other actors involved in the movie include Talia Shire, Burt Young, Carl Weathers as Apollo Creed, Burgess Meredith and others.",
                });
            x.HasData(
                new Movie
                {
                    Id = 2,
                    MovieName = "Rokki 2",
                    Director = "Sylvester Stallone",
                    Style = "Fighting",
                    Description =
                        "is an American sports drama film starring Sylvester Stallone as boxer Rocky Balboa. Production was organized and overseen by producers Irwin Winkler, Robert Chartoff and their company Chartoff-Winkler Productions, and John Evildsen, who directed the film from Stallone's screenplay, was hired as director. Other actors involved in the movie include Talia Shire, Burt Young, Carl Weathers as Apollo Creed, Burgess Meredith and others.",
                });
        });
        _modelBuilder.Entity<Session>(s =>
        {
            s.HasData(
                new Session
                {
                    Id = 1,
                    Room = 2,
                    Price = 100,
                    DateTime = DateTime.Now,
                    MovieId = 1
                });
            s.HasData(
                new Session
                {
                    Id = 2,
                    Room = 6,
                    Price = 200,
                    DateTime = DateTime.Now,
                    MovieId = 2
                });
        });
    }
}