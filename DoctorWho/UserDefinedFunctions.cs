using DoctorWho.Db.DBContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho
{
    public class UserDefinedFunctions
    {
        public string GetCompanions(int EpisodeId)
        {
            using var context = new DoctorWhoCoreDbContext();

            var Companions = context.Episodes
                                    .Select(e => context.PrintCompanions(EpisodeId))
                                    .FirstOrDefault();
            return Companions;
        }

        public string GetEnemies(int EpisodeId)
        {
            using var context = new DoctorWhoCoreDbContext();

            var Enemies = context.Episodes
                                    .Select(e => context.PrintEnemies(EpisodeId))
                                    .FirstOrDefault();
            return Enemies;
        }
    }
}
