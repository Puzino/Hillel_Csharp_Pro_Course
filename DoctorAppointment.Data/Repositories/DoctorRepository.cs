using DoctorAppointment.Data.Configuration;
using DoctorAppointment.Data.Interfaces;
using DoctorAppointment.Domain.Entities;
using Newtonsoft.Json;

namespace DoctorAppointment.Data.Repositories
{
    public class DoctorRepository : IDoctorRepository
    {

        public string Path { get; set; }

        public int LastId { get; set; }

        public DoctorRepository()
        {
            dynamic result = ReadFromAppSettings();

            Path = result.Database.Doctors.Parh;
            LastId = result.Database.Doctors.LastId;
        }

        private dynamic ReadFromAppSettings() => JsonConvert.DeserializeObject<dynamic>(File.ReadAllText(Constants.AppSettingsPath));


        private void SaveLastId()
        {
            dynamic result = ReadFromAppSettings();
            result.Database.Doctors.LastId = LastId;

            File.WriteAllText(Constants.AppSettingsPath, result.toString());
        }

        public Doctor Create(Doctor doctor)
        {
            doctor.Id = ++LastId;
            doctor.CreateAt = DateTime.Now;

            File.WriteAllText(Path, JsonConvert.SerializeObject(GetAll().Append(doctor), Formatting.Indented));
            SaveLastId();

            return doctor;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Doctor> GetAll()
        {
            throw new NotImplementedException();
        }

        public Doctor GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Doctor Update(int id, Doctor doctor)
        {
            throw new NotImplementedException();
        }
    }
}

