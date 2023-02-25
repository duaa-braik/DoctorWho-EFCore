using DoctorWho;

public class Program
{
    public static void Main(string[] args)
    {
        var UserDefinedFunctions = new UserDefinedFunctions();

        int EpisodeId = 3;

        Console.WriteLine(UserDefinedFunctions.GetCompanions(EpisodeId));
        Console.WriteLine(UserDefinedFunctions.GetEnemies(EpisodeId));
    }
}