using DoctorAppointment.Domain.Entities;
using DoctorAppointment.Service.Interfaces;
using DoctorAppointment.Service.Services;

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
            Console.WriteLine("Current doctors list: ");
            var docs = _doctroService.GetAll();

            foreach (var doc in docs)
            {
                Console.WriteLine(doc.Name);
            }

            Console.WriteLine("Adding doctor: ");
            var newDoctor = new Doctor
            {
                Name = "Vasya",
                Surname = "Petrov",
                Experiance = 20,
                DoctorType = Domain.Enums.DoctorTypes.Dentist,
            };
            _doctroService.Create(newDoctor);
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



