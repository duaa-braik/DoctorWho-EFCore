using DoctorWho.Db.DataModels;
using DoctorWho.Db.DBContext;
using Microsoft.EntityFrameworkCore;

namespace DoctorWho.Db.Repositories
{
    public class DoctorRepository : IDoctorRepository
    {
        private readonly DoctorWhoCoreDbContext context;

        public DoctorRepository(DoctorWhoCoreDbContext context)
        {
            this.context = context ?? new DoctorWhoCoreDbContext();
        }
        public int Add(Doctor doctor)
        {
            context.Doctors.Add(doctor);
            return context.SaveChanges();
        }

        public int Delete(int Id)
        {
            var doctor = GetDoctorWithEpisodes(Id);

            if (doctor != null)
            {
                context.Doctors.Remove(doctor);
                return context.SaveChanges();
            }
            return 0;
        }

        public Doctor GetById(int Id)
        {
            return context.Doctors.Find(Id);
        }

        public int Update(Doctor doctor)
        {
            var OldDoctor = GetById(doctor.DoctorId);

            if (OldDoctor != null)
            {
                OldDoctor.DoctorNumber = doctor.DoctorNumber;
                OldDoctor.DoctorName = doctor.DoctorName;
                OldDoctor.BirthDate = doctor.BirthDate;
                OldDoctor.FirstEpisodeDate = doctor.FirstEpisodeDate;
                OldDoctor.LastEpisodeDate = doctor.LastEpisodeDate;
                return context.SaveChanges();
            }
            return 0;
        }

        public Doctor GetDoctorWithEpisodes(int Id)
        {
            return context.Doctors
                .Include(d => d.Episodes)
                .FirstOrDefault(d => d.DoctorId == Id);
        }

        public IEnumerable<Doctor> GetAllDoctors()
        {
            return context.Doctors.ToList();
        }
    }
}
