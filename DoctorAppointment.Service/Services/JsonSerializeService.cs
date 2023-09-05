using DoctorAppointment.Data.Interfaces;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace DoctorAppointment.Service.Services
{
    public class JsonSerializeService : ISerialize
    {
        public T Deserialize<T>(string path)
        {
            var json = File.ReadAllText(path);
            return JsonConvert.DeserializeObject<T>(json);
        }

        public void Serialize<T>(string path, T data)
        {
            File.WriteAllText(path, JsonConvert.SerializeObject(data, Formatting.Indented));
        }
    }
}

