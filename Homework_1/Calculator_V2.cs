using System;
namespace Hillel_Csharp_Pro
{
	public class Calculator_V2
	{
        public void Addition(double first_number, double second_number)
        {
            Console.WriteLine(first_number + second_number);
        }

        public void Dividing(double first_number, double second_number)
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

        public void Deduction(double first_number, double second_number)
        {
            Console.WriteLine($"{first_number - second_number}");
        }

        public void Multiplication(double first_number, double second_number)
        {
            Console.WriteLine($"{first_number * second_number}");
        }
    }
}

