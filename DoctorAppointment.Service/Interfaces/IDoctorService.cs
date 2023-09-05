using DoctorAppointment.Domain.Entities;
using DoctorAppointment.Service.ViewModels;

namespace DoctorAppointment.Service.Interfaces
{
	public interface IDoctorService
	{
        DoctorViewModel Create(Doctor doctor);

        public IEnumerable<DoctorViewModel> GetAll();

        DoctorViewModel? Get(int id); 

        bool Delete(int id);

        DoctorViewModel Update(int id, Doctor doctor); 

        string ShowInfo(Doctor doctor); // doctor view model
    }
}

