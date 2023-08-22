using System;
namespace Homework_5
{
	public class Shop : IDisposable
    {
        private bool disposed = false;

        public string Name { get; set; }
        public string Address { get; set; }
        public string Type { get; set; }

        public Shop(string name, string address, string type)
		{
			Name = name;
			Address = address;
			Type = type;
		}

		public void ShowInfo()
		{
			Console.WriteLine($"Name: {Name}\nAddress: {Address}\nType: {Type}");
		}

        public void Dispose()
        {
            Console.WriteLine($"Shop {Name} has been deleted");
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

        ~Shop()
		{
            Console.WriteLine($"Shop {Name} has been deleted");
        }
    }
}

