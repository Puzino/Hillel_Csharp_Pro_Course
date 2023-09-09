using System;

/*
 * Завдання 3 (Структури)
	Створіть структуру «Десяткове число». 
	Визначте в ній необхідні поля і методи. Реалізуйте наступну функціональність: 
	■ Перевести число у двійкову систему; 
	■ Перевести число у вісімкову систему; 
	■ Перевести число у шістнадцяткову систему.
*/

namespace Homework_2
{
	public struct DecimalNumber
	{
		// Поля
		private int _decimalNumber;

		// Конструкторы
		public DecimalNumber(int value)
		{
			this._decimalNumber = value;
		}

		// Методы

		public string ToBinary() => Convert.ToString(_decimalNumber, 2);

		public string ToOctal() => Convert.ToString(_decimalNumber, 8);

		public string ToHexadecimal() => Convert.ToString(_decimalNumber, 16);


    }
}

