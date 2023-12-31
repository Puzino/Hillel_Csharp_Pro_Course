﻿using DoctorAppointment.Service.Interfaces;
using DoctorAppointment.Service.Services;
using DoctorAppointment.Domain.Entities;
using DoctorAppointment.Domain.Enums;
using DoctorAppointment.Data.Interfaces;
using DoctorAppointment.Data.Configuration;

namespace DoctorAppointment
{

    class DoctorAppointment
    {
        private readonly IDoctorService _doctroService;

        public DoctorAppointment(string appSettings, ISerialize serializeService)
        {
            _doctroService = new DoctorService(appSettings, serializeService);
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
                            try
                            {
                                Console.WriteLine("Current doctors list: ");
                                var docs = _doctroService.GetAll();

                                foreach (var doc in docs)
                                {
                                    _doctroService.ShowInfo(doc);

                                }
                                break;
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                                break;
                            }


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
                                    Experience = experiance,
                                    DoctorType = doctorType,
                                    Phone = phone,
                                    Email = email,
                                    Salary = salary,
                                };
                                _doctroService.Create(newDoctor);
                                Console.WriteLine("Successful creation!");
                                _doctroService.ShowInfo(newDoctor);
                                break;
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                                break;
                            }


                        case ChoiceMenu.Exit:
                            break;

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
            Console.WriteLine("Choice type of file save/read information\n\t1. JSON\n\t2. XML");

            DoctorAppointment? doctorAppointment = null;

            string? choice = Console.ReadLine();
            try
            {
                switch (choice)
                {

                    case "1":
                        {
                            doctorAppointment = new DoctorAppointment(Constants.JsonAppSettingsPath, new JsonSerializeService());
                            break;
                        }
                    case "2":
                        {
                            doctorAppointment = new DoctorAppointment(Constants.XmlAppSettingsPath, new XmlSerializeService());
                            break;
                        }

                    default:
                        Console.WriteLine("Wrong choice...");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            doctorAppointment.Menu();
        }
    }

}



