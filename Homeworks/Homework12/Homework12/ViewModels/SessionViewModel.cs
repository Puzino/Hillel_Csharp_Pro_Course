using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Homework12.Models;
namespace Homework12.ViewModels;

public class SessionViewModel
{
    [Required] public int Room { get; set; }

    [Required]
    [Column(TypeName = "decimal(6, 2)")]
    public double Price { get; set; }

    [Required]
    [DataType(DataType.DateTime)]
    public DateTime DateTime { get; set; }
    
    [Required] public int MovieId { get; set; }
}