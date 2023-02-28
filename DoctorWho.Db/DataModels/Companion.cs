using DoctorWho.Db.DBContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db.DataModels
{
    public class Companion
    {
        private DoctorWhoCoreDbContext context;

        public Companion() { }
        public Companion(DoctorWhoCoreDbContext Context)
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

        public int CompanionId { get; set; }
        public string CompanionName { get; set; }
        public string? WhoPlayed { get; set; }

        public List<Episode> Episodes { get; set; }

        private Companion companion;

        public void Add(string CompanionName, string WhoPlayed)
        {
            companion = new Companion
            {
                CompanionName = CompanionName,
                WhoPlayed = WhoPlayed
            };

            context.Companions.Add(companion);
            context.SaveChanges();
        }

        public void Update(int Id, string Name, [Optional] string WhoPlayed)
        {
            companion = GetById(Id, context);

            if(companion != null)
            {
                companion.CompanionName = Name;
                if (!string.IsNullOrEmpty(WhoPlayed))
                {
                    companion.WhoPlayed = WhoPlayed;
                }
                context.SaveChanges();
            }
        }

        public void Remove(int Id)
        {
            companion = GetById(Id, context);

            context.Companions.Remove(companion);
            context.SaveChanges();
        }

        public Companion GetById(int Id, DoctorWhoCoreDbContext context)
        {
            return context.Companions.Find(Id);
        }
    }
}
