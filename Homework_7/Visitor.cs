namespace Homework_7;
class Visitor
{
    private readonly Barbershop barbershop;
    private readonly string name;

    public Visitor(Barbershop barbershop, string name)
    {
        this.barbershop = barbershop;
        this.name = name;
    }

    public void EnterBarbershop()
    {
        barbershop.VisitBarbershop(name);
        // Реалізуйте логіку для стрижки тут
        barbershop.LeaveBarbershop(name);
    }
}
