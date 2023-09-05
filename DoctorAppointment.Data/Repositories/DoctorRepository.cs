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

        protected override void SaveLastId()
        {
            dynamic result = ReadFromAppSettings();
            result.Database.Doctors.LastId = LastId;

            serializeService.Serialize(AppSettings, result);
        }
    }
}

