using DoctorWho;
using DoctorWho.Db.DataModels;

public class Program
{
    public static void Main(string[] args)
    {
        var UserDefinedFunctions = new UserDefinedFunctions();
        var Views = new Views();
        var StoredProcedures = new StoredProcedures();

        int EpisodeId = 3;

        UserDefinedFunctions.GetCompanions(EpisodeId);
        UserDefinedFunctions.GetEnemies(EpisodeId);

        Views.GetEpisodesDetails();

        StoredProcedures.GetTopAppearences();

    }
}