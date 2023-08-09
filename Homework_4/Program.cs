namespace Homework_4;

class Program
{
    static void Main(string[] args)
    {
        
        // Task №1
        Employee employee = new Employee(100);

        employee.PrintSalary();

        double salary1= employee + 40;
        double minus1 = employee - 20;
        bool equals1 = employee == 100;
        bool not_equals1 = employee != 100;
        bool more1 = employee > 90;
        bool less1 = employee < 110;
        bool operator_equals1 = employee.Equals(employee);

        Console.WriteLine("Salary+ : " + salary1);
        Console.WriteLine("Salary- : " + minus1);
        Console.WriteLine("Salary== : " + equals1);
        Console.WriteLine("Salary!= : " + not_equals1);
        Console.WriteLine("Salary> : " + more1);
        Console.WriteLine("Salary< : " + less1);
        Console.WriteLine($"Operator equals: {operator_equals1}");

        Console.WriteLine();

        //Task №2

        Matrix matrix1 = new Matrix(2, 2);
        matrix1[0, 0] = 1;
        matrix1[0, 1] = 2;
        matrix1[1, 0] = 3;
        matrix1[1, 1] = 4;

        Matrix matrix2 = new Matrix(2, 2);
        matrix2[0, 0] = 5;
        matrix2[0, 1] = 6;
        matrix2[1, 0] = 7;
        matrix2[1, 1] = 8;

        Matrix sum = matrix1 + matrix2;
        Matrix difference = matrix1 - matrix2;
        Matrix product = matrix1 * matrix2;
        Matrix scaledMatrix = matrix1 * 2;

        bool areEqual = matrix1 == matrix2;
        bool areNotEqual = matrix1 != matrix2;

        Console.WriteLine("Matrix 1:");
        PrintMatrix(matrix1);

        Console.WriteLine("\nMatrix 2:");
        PrintMatrix(matrix2);

        Console.WriteLine("\nSum:");
        PrintMatrix(sum);

        Console.WriteLine("\nDifference:");
        PrintMatrix(difference);

        Console.WriteLine("\nProduct:");
        PrintMatrix(product);

        Console.WriteLine("\nScaled Matrix:");
        PrintMatrix(scaledMatrix);

        Console.WriteLine("\nMatrix 1 is equal to Matrix 2: " + areEqual);
        Console.WriteLine("Matrix 1 is not equal to Matrix 2: " + areNotEqual);

        //Task №3

        City city1 = new City(100);
        City city2 = new City(40);

        city1.PrintPeople();
        city2.PrintPeople();

        int sum3 = city1 + city2;
        int different3 = city1 - city2;
        bool equals3 = city1 == city2;
        bool not_equals3 = city1 != city2;
        bool more3 = city1 > city2;
        bool less3 = city1 < city2;

        Console.WriteLine($"Sum: {sum3}");
        Console.WriteLine($"Different: {different3}");
        Console.WriteLine($"Equals: {equals3}");
        Console.WriteLine($"Not equals: {not_equals3}");
        Console.WriteLine($"More : {more3}");
        Console.WriteLine($"Less : {less3}");

        //Task №4
        CreditСard creditСard_1 = new CreditСard(money:1200, cvv:132);

        double sum4 = creditСard_1 + 200;
        double different4 = creditСard_1 - 100;
        bool equals4 = creditСard_1 == 200;
        bool not_equals4 = creditСard_1 != 200;
        bool more4 = creditСard_1 > 1200;
        bool less4 = creditСard_1 < 1000;
        bool operator_equals4 = creditСard_1.Equals(creditСard_1);

        Console.WriteLine($"Sum: {sum4}");
        Console.WriteLine($"Different: {different4}");
        Console.WriteLine($"Equals: {equals4}");
        Console.WriteLine($"Not equals: {not_equals4}");
        Console.WriteLine($"More: {more4}");
        Console.WriteLine($"Less: {less4}");
        Console.WriteLine($"Operator equals: {operator_equals4}");
    }

    static void PrintMatrix(Matrix matrix)
    {
        for (int i = 0; i < matrix.Rows; i++)
        {
            for (int j = 0; j < matrix.Columns; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}