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

        public DoctorService(string appSettings, ISerialize serializeService)
        {
            _doctorRepository = new DoctorRepository(appSettings, serializeService);
        }

        public Doctor Create(Doctor doctor) // return DoctorView Model
        {
            return _doctorRepository.Create(doctor);
        }

        public bool Delete(int id)
        {
            return _doctorRepository.Delete(id);
        }

        //public DoctorViewModel? Get(int id)
        public Doctor? Get(int id)
        {
            return _doctorRepository.GetById(id);
        }

        //public IEnumerable<DoctorViewModel> GetAll()
        public IEnumerable<Doctor> GetAll()
        {
            //var doctors = _doctorRepository.GetAll();
            //var doctorViewModels = doctors.Select(x => x.ConvertTo());
            //return doctorViewModels;
            return _doctorRepository.GetAll();

        }

        public void ShowInfo(Doctor doctor)
        {
            ////DoctorViewModel doctor = doctor1.ConvertTo();
            //string text = $"ID: {doctor.Id}" +
            //    $"Doctor: {doctor.Surname} {doctor.Name}, " +
            //    $"Doctor type: {doctor.DoctorType}, " +
            //    $"Phone: {doctor.Phone ?? "--"}, " +
            //    $"Email: {doctor.Email ?? "--"}, " +
            //    $"Experiance: {doctor.Experiance} years. " +
            //    $"Salary: {doctor.Salary}$.";
            //return text;
            _doctorRepository.ShowInfo(doctor);
        }

        //public DoctorViewModel Update(int id, Doctor doctor)
        public Doctor Update(int id, Doctor doctor)
        {
            return _doctorRepository.Update(id, doctor);
        }
    }
}

