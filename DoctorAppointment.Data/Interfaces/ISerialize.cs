using System;
namespace DoctorAppointment.Data.Interfaces
{
    public interface ISerialize
    {
        void Serialize<T>(string path, T data);

        T Deserialize<T>(string path);
    }
}

