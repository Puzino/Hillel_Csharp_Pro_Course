using System;
namespace Hillel_Csharp_Pro
{
	public class Calculator_V1
	{
		private double first_number;
		private double second_number;

        public Calculator_V1(double first_number, double second_number)
		{
			this.first_number = first_number;
			this.second_number = second_number;
		}

		public void Addition()
		{
			Console.WriteLine($"{first_number + second_number}");
		}

		public void Dividing()
		{
			if (first_number == 0 || second_number == 0)
			{
				Console.WriteLine("На 0 делить нельзя!");
			}
			else
			{
                Console.WriteLine($"{first_number / second_number}");
            }
        }

		public void Deduction()
		{
            Console.WriteLine($"{first_number - second_number}");

        }

		public void Multiplication()
		{
            Console.WriteLine($"{first_number * second_number}");
        }
    }
}

