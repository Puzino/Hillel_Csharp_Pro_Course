using System;
namespace DoctorAppointment.Domain.Entities
{
	public abstract class Auditable
	{
        public int Id { get; set; }

        public DateTime CreateAt { get; set; }

		public DateTime UpdateAt { get; set; }

	}
}

