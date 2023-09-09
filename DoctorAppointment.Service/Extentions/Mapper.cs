using DoctorAppointment.Domain.Entities;
using DoctorAppointment.Domain.Enums;
using DoctorAppointment.Service.ViewModels;

namespace DoctorAppointment.Service.Extentions
{
	public static class Mapper
	{
		public static DoctorViewModel ConvertTo(this Doctor doctor)
		{
			if (doctor == null)
				return null;

			string doctorType = string.Empty;

            doctorType = doctor.DoctorType switch
            {
                DoctorTypes.Dermatologist => "Dermatologist",
                DoctorTypes.Dentist => "Dentist",
                DoctorTypes.FamilyDoctor => "FamilyDoctor",
                DoctorTypes.Paramedic => "Paramedic",
                _ => "Unknown",
            };

            return new DoctorViewModel()
			{
				Name = doctor.Name,
				Surname = doctor.Surname,
				Email = doctor.Email,
				Phone = doctor.Phone,
				DoctorType = doctorType,
				Experiance = doctor.Experiance,
				Salary = doctor.Salary,
			};
        }

        public static Doctor ConvertTo(this DoctorViewModel doctor)
        {
            if (doctor == null)
                return null;

            DoctorTypes doctorType;

            doctorType = Enum.TryParse(doctor.DoctorType, true, out doctorType) ? doctorType : 0;

            return new Doctor()
            {
                Id = doctor.Id,
                Name = doctor.Name,
                Surname = doctor.Surname,
                Email = doctor.Email,
                Phone = doctor.Phone,
                DoctorType = doctorType,
                Experiance = doctor.Experiance,
                Salary = doctor.Salary,
            };
        }
    }
}

