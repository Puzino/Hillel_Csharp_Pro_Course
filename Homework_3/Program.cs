namespace Homework_3;

class Program
{
    static void Main(string[] args)
    {
        List<int> ints = new List<int>() { 5, 2, 1, 4, 3 }; // List int
        ClassArray classArray = new ClassArray(ints); // Class with interfaces
        IOutput output = new ClassArray(ints); // Test

        // TASK №1
        Console.WriteLine("Task #1");

        classArray.Show();
        classArray.ShowInfo("Info from Class");
        output.ShowInfo("Info from Interface");

        // TASK №2
        Console.WriteLine("Task #2");

        Console.WriteLine(classArray.Search(2)); // True
        Console.WriteLine(classArray.Min()); // 1 - MinValue
        Console.WriteLine(classArray.Max()); // 5 - MaxValue
        Console.WriteLine(classArray.Avg()); // 3 - Avg value

        // TASK №3
        Console.WriteLine("Task #3");

        classArray.SortAsc();
        classArray.Show();
        Console.WriteLine();
        classArray.SortDesc();
        classArray.Show();
        Console.WriteLine();
        classArray.SortByParam(true);
        classArray.Show();
    }
}

