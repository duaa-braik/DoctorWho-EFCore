using DoctorWho;
using DoctorWho.Db.DataModels;

public class Program
{
    public static void Main(string[] args)
    {
        var UserDefinedFunctions = new UserDefinedFunctions();
        var Views = new Views();

        int EpisodeId = 3;

        UserDefinedFunctions.GetCompanions(EpisodeId);
        UserDefinedFunctions.GetEnemies(EpisodeId);

        Views.ViewEpisodes();
    }
}