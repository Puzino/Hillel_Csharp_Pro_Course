using DoctorAppointment.Data.Interfaces;
using DoctorAppointment.Service.ViewModels;
using System.Xml.Serialization;

namespace DoctorAppointment.Service.Services
{
    public class XmlSerializeService : ISerialize
    {
        public T Deserialize<T>(string path)
        {
            XmlSerializer serializer = new(typeof(T));

            using FileStream stream = new(path, FileMode.OpenOrCreate);
            return (T)serializer.Deserialize(stream);
        }

        public void Serialize<T>(string path, T data)
        {
            XmlSerializer formatter = new(typeof(T));

            using FileStream fs = new(path, FileMode.OpenOrCreate);
            formatter.Serialize(fs, data);
        }
    }
}

