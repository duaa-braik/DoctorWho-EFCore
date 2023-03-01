using DoctorWho.Db.DataModels;

namespace DoctorWho.Db.Repositories
{
    public interface IDoctorRepository : IRepository<Doctor>
    {
        IEnumerable<Doctor> GetAllDoctors();
        Doctor GetDoctorWithEpisodes(int Id);
    }
}