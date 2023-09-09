using DoctorAppointment.Data.Interfaces;
using DoctorAppointment.Service.ViewModels;
using System.Xml.Serialization;

namespace DoctorAppointment.Service.Services
{
    public class XmlSerializeService : ISerialize
    {
        public T Deserialize<T>(string path)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));


            using (FileStream stream = new FileStream(path, FileMode.OpenOrCreate))
            {
                //DoctorViewModel obj = serializer.Deserialize(stream);
                
                return (T)serializer.Deserialize(stream);
            }
        }

        public void Serialize<T>(string path, T data)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(T));

            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, data);
            }
        }
    }
}

