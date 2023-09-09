using System;
namespace Homework_2
{
	public class Product : Money
	{
        // Поля

        private string NameProduct = string.Empty; // Имя продукта

		// Конструкторы

		public Product(string NameProduct, string NameCurrency, int integer_part, int fractional_part)
			: base(NameCurrency, integer_part, fractional_part)
		{
			this.NameProduct = NameProduct;
		}

		// Методы

		public new void Print()
		{
			Console.WriteLine();
			Console.WriteLine($"Name Product: {NameProduct}.\nValue: {integer_part}.{fractional_part}\nCurrency: {NameCurrency}");
		}

        public void ChangeValues(int first_value, int second_value)
		{
			try
			{
				if ((integer_part - first_value) < 0)
				{
					throw new Exception("Error! - Цена целой части не может быть меньше 0.");
				}
				else if ((fractional_part - second_value) < 0)
				{
                    throw new Exception("Error! - Цена дробной части не может быть меньше 0.");
                }
                else
				{
                    integer_part -= first_value;
                    fractional_part -= second_value;
                }
            }
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
			
		}
	}
}

