using DoctorAppointment.Domain.Entities;
using DoctorAppointment.Service.ViewModels;

namespace DoctorAppointment.Service.Interfaces
{
	public interface IDoctorService
	{
        Doctor Create(Doctor doctor); // doctor

        public IEnumerable<DoctorViewModel> GetAll();

        Doctor? Get(int id); // doctor?

        bool Delete(int id);

        Doctor Update(int id, Doctor doctor); // doctor
    }
}

