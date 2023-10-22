using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Homework12.Models;

public class Session
{
    public int Id { get; set; }

    [Required] public int Room { get; set; }

    [Required]
    [Column(TypeName = "decimal(6, 2)")]
    public double Price { get; set; }

    [Required]
    [DataType(DataType.DateTime)]
    public DateTime DateTime { get; set; }

    [Required] public int MovieId { get; set; }
    
    [ForeignKey("MovieId")]
    public Movie Movie { get; set; }
}