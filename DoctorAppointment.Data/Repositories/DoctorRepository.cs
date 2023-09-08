using DoctorAppointment.Data.Interfaces;
using DoctorAppointment.Domain.Entities;

namespace DoctorAppointment.Data.Repositories
{
    public class DoctorRepository : GenericRepository<Doctor>, IDoctorRepository
    {
        private readonly ISerialize serializeService;

        public override string Path { get; set; }

        public override int LastId { get; set; }

        public DoctorRepository(string appSettings, ISerialize serialize) : base(appSettings, serialize)
        {
            serializeService = serialize;

            var result = ReadFromAppSettings();

            Path = result.Database.Doctors.Path;
            LastId = result.Database.Doctors.LastId;
        }


        public override void ShowInfo(Doctor doctor)
        {
            if (doctor != null)
            {
                string text = $"ID: {doctor.Id} " +
                $"Doctor: {doctor.Surname} {doctor.Name}, " +
                $"Doctor type: {doctor.DoctorType}, " +
                $"Phone: {doctor.Phone ?? "--"}, " +
                $"Email: {doctor.Email ?? "--"}, " +
                $"Experiance: {doctor.Experiance} years. " +
                $"Salary: {doctor.Salary}$.";

                Console.WriteLine(text);
            }
            else
            {
                throw new ArgumentNullException(nameof(doctor) + " can't be null");
            }
        }

        protected override void SaveLastId()
        {
            dynamic result = ReadFromAppSettings();
            result.Database.Doctors.LastId = LastId;

            serializeService.Serialize(AppSettings, result);
        }


    }
}

