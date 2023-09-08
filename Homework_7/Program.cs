using System;
using System.Collections.Generic;
using System.Threading;

class Program
{
    static int maxCustomers = 15;
    static object locker = new object();
    static Queue<Customer> waitingCustomers = new Queue<Customer>();
    static int maxChairs = 3;
    static bool barberSleeping = true;

    static void Main(string[] args)
    {
        Thread barberThread = new Thread(Barber);
        barberThread.Start();

        for (int i = 1; i <= maxCustomers; i++)
        {
            Thread customerThread = new Thread(Customer);
            customerThread.Name = $"Customer {i}";
            customerThread.Start();
            Thread.Sleep(1000);
        }
    }

    static void Barber()
    {
        while (true)
        {
            lock (locker)
            {
                if (waitingCustomers.Count == 0)
                {
                    barberSleeping = true;
                    Console.WriteLine("Парикмахер спит.");
                    Monitor.Wait(locker);
                }

                Customer customer = waitingCustomers.Dequeue();
                Console.WriteLine($"Парикмахер стрижет клиента {customer.Name}.");
                Thread.Sleep(2000);
                Console.WriteLine($"Парикмахер постриг клиента, {customer.Name} уходит.");

            }
        }
    }

    static void Customer()
    {
        Customer customer = new Customer(Thread.CurrentThread.Name);
        Console.WriteLine($"{customer.Name} пришел в парикмахерскую.");

        lock (locker)
        {
            if (waitingCustomers.Count < maxChairs)
            {
                Console.WriteLine($"{customer.Name} сел в кресло в комнате ожидания.");
                waitingCustomers.Enqueue(customer);
                if (barberSleeping)
                {
                    barberSleeping = false;
                    Monitor.Pulse(locker);
                }
            }
            else
            {
                Console.WriteLine($"{customer.Name} ушел, так как нет свободных мест.");
            }
        }
    }
}

class Customer
{
    public string Name { get; }

    public Customer(string name)
    {
        Name = name;
    }
}
