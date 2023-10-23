using System.ComponentModel.DataAnnotations;
using Homework12.Models;
namespace Homework12.ViewModels;

public class MovieViewModel
{
    [Required] [MaxLength(100)] public string MovieName { get; set; }

    [Required] [MaxLength(500)] public string Description { get; set; }


    [Required] [MaxLength(50)] public string Director { get; set; }

    [Required] [MaxLength(50)] public string Style { get; set; }
    
}