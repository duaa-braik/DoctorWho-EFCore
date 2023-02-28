﻿using DoctorWho.Db.DBContext;
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

        public Doctor(DoctorWhoCoreDbContext Context)
        {
            Episodes = new List<Episode>();
            if(Context != null)
            {
                context = Context;
            } else
            {
                context = new DoctorWhoCoreDbContext();
            }
            
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
            doctor = GetById(Id, context);

            if(doctor != null)
            {
                context.Doctors.Remove(doctor);
                return context.SaveChanges();
            }
            return 0;
        }
    }
}
