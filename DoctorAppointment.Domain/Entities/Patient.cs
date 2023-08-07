using DoctorAppointment.Domain.Enums;

namespace DoctorAppointment.Domain.Entities
{
	public class Patient : UserBase
    {
        public IllnessTypes IllnessTypes { get; set; }

        public string? AddittionalInfo { get; set; }

        public string? Address { get; set; }

    }
}

