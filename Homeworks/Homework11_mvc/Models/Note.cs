using System.ComponentModel.DataAnnotations;
namespace Homework11_mvc.Models
{
	public class Note
	{
		[Key]
		public int Id { get; set; }

		[Required]
		public string? NoteName { get; set; }
		
		[Required]
		[DataType(DataType.MultilineText)]
		public string? TextNote { get; set; }

		[Required]
		public DateTime DateCreateNote { get; set; } 

		public string? TagsNote { get; set; }
	}
}

