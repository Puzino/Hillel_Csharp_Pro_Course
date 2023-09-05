using DoctorAppointment.Service.Interfaces;
using DoctorAppointment.Service.Services;
using DoctorAppointment.Domain.Entities;
using DoctorAppointment.Domain.Enums;

namespace DoctorAppointment
{

    class DoctorAppointment
    {
        private readonly IDoctorService _doctroService;

        public DoctorAppointment()
        {
            _doctroService = new DoctorService();
        }

        public void Menu()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Menu:");
                    Console.WriteLine("\t1. Show info about all doctors\n" +
                        "\t2. Add a new doctor\n" +
                        "\t9. Exit from Hospital");
                    ChoiceMenu choiceMenu = (ChoiceMenu)int.Parse(Console.ReadLine());
                    switch (choiceMenu)
                    {
                        case ChoiceMenu.ShowInfo:
                            Console.WriteLine("Current doctors list: ");
                            var docs = _doctroService.GetAll();

                            foreach (var doc in docs)
                            {
                                DoctorTypes doctorType = Enum.Parse<DoctorTypes>(doc.DoctorType);


                                // TODO ТУТ КОСТЫЛЬ !
                                var showDoctor = new Doctor
                                {
                                    Name = doc.Name,
                                    Surname = doc.Surname,
                                    Experiance = doc.Experiance,
                                    DoctorType = doctorType,
                                    Phone = doc.Phone,
                                    Email = doc.Email,
                                    Salary = doc.Salary,
                                };
                                Console.WriteLine(_doctroService.ShowInfo(showDoctor));

                            }
                            break;

                        case ChoiceMenu.AddDoctor:
                            try
                            {
                                Console.WriteLine("Adding doctor: ");
                                Console.WriteLine("Enter name: ");
                                string name = Console.ReadLine();
                                Console.WriteLine("Enter surname: ");
                                string surname = Console.ReadLine();
                                Console.WriteLine("Enter experiance: ");
                                byte experiance = byte.Parse(Console.ReadLine());
                                Console.WriteLine("Enter salary: ");
                                decimal salary = decimal.Parse(Console.ReadLine());
                                Console.WriteLine("Enter email: ");
                                string? email = Console.ReadLine();
                                Console.WriteLine("Enter phone: ");
                                string? phone = Console.ReadLine();

                                Console.WriteLine("Choice type of doctor: ");
                                var choiceDoctorTypes = Enum.GetValues<DoctorTypes>();
                                for (int i = 0; i < choiceDoctorTypes.Length; i++)
                                {
                                    Console.WriteLine($"{i + 1}. {choiceDoctorTypes[i]}");
                                }
                                DoctorTypes doctorType = (DoctorTypes)int.Parse(Console.ReadLine());

                                var newDoctor = new Doctor
                                {
                                    Name = name,
                                    Surname = surname,
                                    Experiance = experiance,
                                    DoctorType = doctorType,
                                    Phone = phone,
                                    Email = email,
                                    Salary = salary,
                                };
                                _doctroService.Create(newDoctor);
                                Console.WriteLine("Successful creation!");
                                Console.WriteLine(_doctroService.ShowInfo(newDoctor));
                                break;
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                                break;
                            }
                            

                        case ChoiceMenu.Exit:
                            throw new Exception("Goodbye!");

                        default:
                            Console.WriteLine("Incorect choice! Enter right number!");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    break;
                }
            }
        }
    }


    class Program
    {
        static void Main()
        {
            var doctorAppointment = new DoctorAppointment();
            doctorAppointment.Menu();
        }
    }

}



