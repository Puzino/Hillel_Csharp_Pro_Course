namespace Hillel_Csharp_Pro;


class Program
{
    static void Main(string[] args)
    {

        // V1

        Console.WriteLine("Calculator V1");

        Calculator_V1 calculator_V1 = new Calculator_V1(4, 2);

        calculator_V1.Addition(); // Сложение
        calculator_V1.Deduction(); // Вычетание
        calculator_V1.Dividing(); // Деление
        calculator_V1.Multiplication(); // Умножение

        // V2

        Console.WriteLine("Calculator V2");

        Calculator_V2 calculator_V2 = new Calculator_V2();

        calculator_V2.Addition(4, 5); // Сложение
        calculator_V2.Deduction(4, 2); // Вычетание
        calculator_V2.Dividing(3, 2); // Деление
        calculator_V2.Multiplication(5, 2); // Умножение
    }
}

