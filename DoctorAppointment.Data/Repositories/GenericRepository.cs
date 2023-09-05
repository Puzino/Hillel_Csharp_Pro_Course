using System.Numerics;
using DoctorAppointment.Data.Configuration;
using DoctorAppointment.Data.Interfaces;
using DoctorAppointment.Domain.Entities;
using Newtonsoft.Json;

namespace DoctorAppointment.Data.Repositories
{
    public abstract class GenericRepository<TSource> : IGenericRepository<TSource> where TSource : Auditable
    {

        public string AppSettings { get; private set; }

        public ISerialize SerializeService { get; private set; }

        public abstract string Path { get; set; }

        public abstract int LastId { get; set; }


        public GenericRepository(string appSettings, ISerialize serializeService)
        {
            AppSettings = appSettings;
            SerializeService = serializeService;
        }


        public TSource Create(TSource source)
        {
            source.Id = ++LastId;
            source.CreateAt = DateTime.Now;

            SerializeService.Serialize(Path, GetAll().Append(source));

            SaveLastId();

            return source;
        }

        public bool Delete(int id)
        {
            if (GetById(id) is null)
                return false;

            SerializeService.Serialize(Path, GetAll().Where(x => x.Id != id));

            return true;
        }

        public IEnumerable<TSource> GetAll()
        {
            
            return SerializeService.Deserialize<List<TSource>>(Path);
        }

        public TSource? GetById(int id)
        {
            return GetAll().FirstOrDefault(x => x.Id == id);
        }

        public TSource Update(int id, TSource source)
        {
            source.UpdateAt = DateTime.Now;
            source.Id = id;

            SerializeService.Serialize(Path, GetAll().Select(x => x.Id == id ? source : x));

            return source;
        }

        //public abstract void ShowInfo(TSource source);

        protected abstract void SaveLastId();

        protected Repository ReadFromAppSettings()
        {
            return SerializeService.Deserialize<Repository>(AppSettings);
        }

    }
}

