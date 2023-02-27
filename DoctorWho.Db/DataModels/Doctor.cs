using DoctorWho.Db.DBContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db.DataModels
{
    public class Doctor
    {
        public Doctor()
        {
            Episodes = new List<Episode>();
        }

        public int DoctorId { get; set; }
        public int DoctorNumber { get; set; }
        public string DoctorName { get; set; }
        public DateTime? BirthDate { get; set; }
        public DateTime FirstEpisodeDate { get; set; }
        public DateTime LastEpisodeDate { get; set; }

        public List<Episode> Episodes { get; set; }

        private Doctor doctor;

        public Doctor GetById(int Id, DoctorWhoCoreDbContext context)
        {
            return context.Doctors.Find(Id);
        }

        public void Add(Doctor Doctor)
        {
            var context = new DoctorWhoCoreDbContext();
            doctor = Doctor;
            
            context.Doctors.Add(doctor);
            context.SaveChanges();

        }

        public void Update(int Id)
        {

        }

        public void Delete(int Id)
        {
            var context = new DoctorWhoCoreDbContext();
            doctor = GetById(Id, context);
            context.Doctors.Remove(doctor);
            context.SaveChanges();
        }
    }
}
