using System;

/*
	+ Завдання 1 (ООП)
	+ Запрограмуйте клас Money (об'єкт класу оперує однією валютою) для роботи з грошима. 
	+ У класі мають бути передбачені: поле для зберігання цілої частини грошей (долари, євро, гривні тощо) і поле для зберігання копійок (центи, євроценти, копійки тощо) 
	+ Реалізувати методи виведення суми на екран, задання значень частин (цілої частини грошей та копійок). 
	+ На базі класу Money створити клас Product для роботи з продуктом або товаром. 
	+ Реалізувати метод, який дозволяє зменшити ціну на задане число. 
	+ Для кожного з класів реалізувати необхідні методи і поля. 
	+ Додати iнкапсуляцiю до полiв та методiв якщо треба.
*/


namespace Homework_2
{
	public class Money
	{
		// Поля

		protected string NameCurrency = "without value.."; // Название валюты
		protected int integer_part; // Целая часть
		protected int fractional_part; // Дробная часть

        // Конструкторы

        public Money() { }

		public Money(string NameCurrency)
		{
			this.NameCurrency = NameCurrency;
        }

		public Money(int integer_part, int fractional_part)
		{
			this.integer_part = integer_part;
			this.fractional_part = fractional_part;
        }

		public Money(string NameCurrency, int integer_part, int fractional_part)
		{
            this.NameCurrency = NameCurrency;
            this.integer_part = integer_part;
            this.fractional_part = fractional_part;
        }

		// Методы

        public void Print()
		{
			Console.WriteLine($"Value: {integer_part}.{fractional_part} Currency: {NameCurrency}");
		}

		public void ChangeValueIntegerPart(int value)
		{
			integer_part = value;
		}

        public void ChangeValueFractionalPart(int value)
        {
            fractional_part = value;
        }

		public void SetСurrency(string value)
		{
            NameCurrency = value;
        }
    }
}

