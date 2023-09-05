using DoctorAppointment.Data.Interfaces;
using DoctorAppointment.Data.Repositories;
using DoctorAppointment.Domain.Entities;
using DoctorAppointment.Service.Extentions;
using DoctorAppointment.Service.Interfaces;
using DoctorAppointment.Service.ViewModels;

namespace DoctorAppointment.Service.Services
{
	public class DoctorService : IDoctorService
	{
        private readonly IDoctorRepository _doctorRepository;

        public DoctorService()
        {
            _doctorRepository = new DoctorRepository();
        }

        public DoctorViewModel Create(Doctor doctor)
        {
            return _doctorRepository.Create(doctor).ConvertTo();
        }

        public bool Delete(int id)
        {
            return _doctorRepository.Delete(id);
        }

        public DoctorViewModel? Get(int id)
        {
            return _doctorRepository.GetById(id).ConvertTo();
        }

        public IEnumerable<DoctorViewModel> GetAll()
        {
            var doctors = _doctorRepository.GetAll();
            var doctorViewModels = doctors.Select(x => x.ConvertTo());
            return doctorViewModels;

        }

        public string ShowInfo(Doctor doctor)
        {
            string text = $"Doctor: {doctor.Surname} {doctor.Name}, " +
                $"Doctor type: {doctor.DoctorType}, " +
                $"Phone: {doctor.Phone ?? "--"}, " +
                $"Email: {doctor.Email ?? "--"}, " +
                $"Experiance: {doctor.Experiance} years. " +
                $"Salary: {doctor.Salary}$.";
            return text;
        }

        public DoctorViewModel Update(int id, Doctor doctor)
        {
            return _doctorRepository.Update(id, doctor).ConvertTo();
        }
    }
}

