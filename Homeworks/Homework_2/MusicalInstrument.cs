using System;

/*
 * Завдання 2 (ООП)
	+ Створити базовий клас «Музичний інструмент» і похідні класи: «Скрипка», «Тромбон», «Укулеле», «Віолончель». 
	+ За допомогою конструктора, встановити назву до кожного музичного інструменту і його характеристики. 
	+ Реалізуйте для кожного з класів методи:
	+ ■ Sound — видає звук музичного інструменту (пишемо текстом у консоль); 
	+ ■ Show — відображає назву музичного інструменту; 
	+ ■ Desc — відображає опис музичного інструменту; 
	+ ■ History — відображає історію створення музичного інструменту.
	+ Додати iнкапсуляцiю до полiв та методiв якщо треба.

*/

namespace Homework_2
{
	public class MusicalInstrument
	{
		// Поля
		protected string InstrumentName = string.Empty;
		protected decimal Length;
		protected decimal Width;
		protected string Description = string.Empty;

		protected string InstrumentalSound = string.Empty;
		protected string InstrumentalHistory = string.Empty;

		// Констуркторы
        public MusicalInstrument(string instrumentName, decimal length, decimal width, string instrumentalSound, string instrumentalHistory, string description)
        {
			InstrumentName = instrumentName;
			Length = length;
			Width = width;
			Description = description;

			InstrumentalSound = instrumentalSound;
			InstrumentalHistory = instrumentalHistory;
        }

		// Методы

		public void Sound()
		{
			Console.WriteLine($"Sound: {InstrumentalSound}");
		}

		public void Show()
		{
			Console.WriteLine($"Name: {InstrumentName}");
			Console.WriteLine($"Size: {Length}cm. length, {Width}cm. width.");
		}

		public void Desc()
		{
			Console.WriteLine($"Descroption: {Description}");
		}

		public void History()
		{
			Console.WriteLine($"History: {InstrumentalHistory} year.");
		}

    }
}

