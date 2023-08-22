using System;
namespace DoctorAppointment.Domain.Entities
{
	public abstract class UserBase : Auditable
	{

        public string Name { get; set; }

        public string Surname { get; set; }

        public string? Phone { get; set; }

        public string? Email { get; set; }

	}
}

