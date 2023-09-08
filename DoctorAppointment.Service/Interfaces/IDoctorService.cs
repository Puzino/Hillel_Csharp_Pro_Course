using DoctorAppointment.Domain.Entities;
using DoctorAppointment.Service.ViewModels;
using DoctorAppointment.Service.Interfaces;

namespace DoctorAppointment.Service.Interfaces
{
	public interface IDoctorService : IService<Doctor>
	{
        //DoctorViewModel Create(Doctor doctor);

        //public IEnumerable<DoctorViewModel> GetAll();

        //DoctorViewModel? Get(int id); 

        //bool Delete(int id);

        //DoctorViewModel Update(int id, Doctor doctor); 

        //void ShowInfo(Doctor doctor); // doctor view model
    }
}

