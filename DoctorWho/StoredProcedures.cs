using DoctorWho.Db.DBContext;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace DoctorWho
{
    public class StoredProcedures
    {
        public List<List<string>> GetTopAppearences()
        {
            using var context = new DoctorWhoCoreDbContext();
            List<List<string>> TopCharacters;

            try
            {
                DbDataReader reader = ExecuteStoredProcedure(context);

                var topCompanions = new List<string>();
                var topEnemies = new List<string>();

                ReadCompanions(reader, topCompanions);
                reader.NextResult();
                ReadEnemies(reader, topEnemies);

                TopCharacters = new List<List<string>>
                    {
                        topCompanions,
                        topEnemies
                    };

            }
            finally
            {
                context.Database.GetDbConnection().Close();
            }
            return TopCharacters;
        }

        private static DbDataReader ExecuteStoredProcedure(DoctorWhoCoreDbContext context)
        {
            var Command = context.Database.GetDbConnection().CreateCommand();
            Command.CommandText = "[dbo].[spSummariseEpisodes]";

            context.Database.GetDbConnection().Open();

            var reader = Command.ExecuteReader();
            return reader;
        }

        private static void ReadEnemies(DbDataReader reader, List<string> topEnemies)
        {
            while (reader.Read())
            {
                topEnemies.Add(reader.GetString(0));
            }
        }

        private static void ReadCompanions(DbDataReader reader, List<string> topCompanions)
        {
            while (reader.Read())
            {
                topCompanions.Add(reader.GetString(0));
            }
        }
    }
}
