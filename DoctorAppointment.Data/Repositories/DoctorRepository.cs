using DoctorAppointment.Data.Configuration;
using DoctorAppointment.Data.Interfaces;
using DoctorAppointment.Domain.Entities;
using DoctorAppointment.Service

namespace DoctorAppointment.Data.Repositories
{
    public class DoctorRepository : GenericRepository<Doctor>, IDoctorRepository
    {

        public override string Path { get; set; }

        public override int LastId { get; set; }

        public DoctorRepository()
        {
            dynamic result = ReadFromAppSettings();

            Path = result.Database.Doctors.Path;
            LastId = result.Database.Doctors.LastId;
        }

        public override void ShowInfo(Doctor doctor)
        {
            Console.WriteLine($"ID: {doctor.Id}, " +
                $"Doctor: {doctor.Surname} {doctor.Name}, " +
                $"Doctor type: {doctor.DoctorType}, " +
                $"Phone: {doctor.Phone ?? "--"}, " +
                $"Email: {doctor.Email ?? "--"}, " +
                $"Experiance: {doctor.Experiance} years. " +
                $"Salary: {doctor.Salary}$.");
            Console.WriteLine();
        }

        protected override void SaveLastId()
        {
            dynamic result = ReadFromAppSettings();
            result.Database.Doctors.LastId = LastId;

            File.WriteAllText(Constants.AppSettingsPath, result.ToString());
        }
    }
}

