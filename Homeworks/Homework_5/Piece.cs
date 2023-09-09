using System;
namespace Homework_5
{
	public class Piece : IDisposable
	{
        private bool disposed = false;

        public string Name { get; protected set; }
		public string Author { get; protected set; }
		public string Genre { get; protected set; }
		public string Year { get; protected set; }

		public Piece(string name, string author, string genre, string year)
		{
			Name = name;
			Author = author;
			Genre = genre;
			Year = year;
		}

		public void ShowInfo()
		{
			Console.WriteLine($"Piece: {Name}\nAuthor: {Author}\nGenre: {Genre}\nYear: {Year}");
		}

        public void Dispose()
        {
            Console.WriteLine($"Piece {Name} has been deleted");
            Dispose(true);
			GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
		{
			if (disposed) return;
			if (disposing)
			{
                // Очищяем ресурсы
            }
            disposed = true;
		}

		~Piece()
		{
            Console.WriteLine($"Piece {Name} has been deleted");
        }
	}
}

