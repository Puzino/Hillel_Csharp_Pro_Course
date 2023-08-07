﻿using DoctorAppointment.Domain.Entities;

namespace DoctorAppointment.Data.Interfaces
{
    public interface IDoctorRepository
	{
        Doctor Create(Doctor doctor);

        Doctor GetById(int id);

        Doctor Update(int id, Doctor doctor);

        IEnumerable<Doctor> GetAll();

        bool Delete(int id);
    }
}

