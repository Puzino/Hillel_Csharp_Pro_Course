namespace Homework_5;

class Program
{
    static void Main(string[] args)
    {
        // Task №1
        using Piece piece = new("Gamlet", "Shekspir", "Tragedy", "1603");

        //Task №2
        using Shop shop = new Shop("Analnaya Radost`", "Gagarina 23", "Sex Shop");

        // Task №3
        piece.ShowInfo();

        Console.WriteLine();

        shop.ShowInfo();

    }
}

