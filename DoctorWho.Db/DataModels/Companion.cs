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
        public Companion()
        {
            Episodes = new List<Episode>();
        }

        public int CompanionId { get; set; }
        public string CompanionName { get; set; }
        public string? WhoPlayed { get; set; }

        public List<Episode> Episodes { get; set; }

        private Companion companion;

        public void Add(string CompanionName, string WhoPlayed)
        {
            using var context = new DoctorWhoCoreDbContext();

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
            using var context = new DoctorWhoCoreDbContext();

            companion = GetById(Id, context);
            Console.WriteLine(context.Companions.Find(Id));

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
            using var context = new DoctorWhoCoreDbContext();

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
