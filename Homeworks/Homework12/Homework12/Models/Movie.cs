using System.ComponentModel.DataAnnotations;

namespace Homework12.Models;

public class Movie
{
    public int Id { get; set; }

    [Required] [MaxLength(100)] public string MovieName { get; set; }

    [Required] [MaxLength(50)] public string Director { get; set; }

    [Required] [MaxLength(50)] public string Style { get; set; }

    [Required] [MaxLength(500)] public string Description { get; set; }

    public ICollection<Session> Sessions { get; set; } = new List<Session>();
}