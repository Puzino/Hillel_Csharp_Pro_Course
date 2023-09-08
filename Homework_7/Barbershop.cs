namespace Homework_7;
class Barbershop
{
    private readonly object lockObject = new object();
    private bool barberSleeping = true;

    public void VisitBarbershop(string visitorName)
    {
        lock (lockObject)
        {
            if (barberSleeping)
            {
                Console.WriteLine($"{visitorName} розбудив перукаря і чекає на стрижку.");
                barberSleeping = false;
                // Розпочніть стрижку
            }
            else
            {
                Console.WriteLine($"{visitorName} чекає в приймальні.");
                // Додайте відвідувача до черги
            }
        }
    }

    public void LeaveBarbershop(string visitorName)
    {
        lock (lockObject)
        {
            Console.WriteLine($"{visitorName} завершив стрижку і покидає перукарню.");
            barberSleeping = true;
            // Повідомте про завершену стрижку та розбудьте перукаря, якщо в черзі є інші відвідувачі
        }
    }
}
