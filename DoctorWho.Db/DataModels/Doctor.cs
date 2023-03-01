using DoctorWho.Db.DBContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db.DataModels
{
    public class Doctor
    {
        private DoctorWhoCoreDbContext context;

        public Doctor() {
            context = new DoctorWhoCoreDbContext();
        }
        public Doctor(DoctorWhoCoreDbContext Context)
        {
            Episodes = new List<Episode>();
            context = Context ?? new DoctorWhoCoreDbContext();
        }

        public int DoctorId { get; set; }
        public int DoctorNumber { get; set; }
        public string DoctorName { get; set; }
        public DateTime? BirthDate { get; set; }
        public DateTime FirstEpisodeDate { get; set; }
        public DateTime LastEpisodeDate { get; set; }

        public List<Episode> Episodes { get; set; }

        private Doctor doctor;

        public Doctor GetById(int Id)
        {
            return context.Doctors.Find(Id);
        }

        public Doctor GetDoctorWithEpisodes(int Id)
        {
            return context.Doctors
                .Include(d => d.Episodes)
                .FirstOrDefault(d => d.DoctorId == Id);
        }

        public int Add(Doctor Doctor)
        {
            doctor = Doctor;
            
            context.Doctors.Add(doctor);
            return context.SaveChanges();

        }

        public void Update(int Id)
        {

        }

        public int Delete(int Id)
        {
            doctor = GetDoctorWithEpisodes(Id);

            if(doctor != null)
            {
                context.Doctors.Remove(doctor);
                return context.SaveChanges();
            }
            return 0;
        }

        public IEnumerable<Doctor> GetAllDoctors()
        {
            return context.Doctors.ToList();
        }
    }
}
