using Homework11_mvc.Models;
using Microsoft.EntityFrameworkCore;

namespace Homework11_mvc.Data
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base (options) { }
		public DbSet<Note> Notes { get; set; }
		public DbSet<Contact> Contacts { get; set; }
	}
}

