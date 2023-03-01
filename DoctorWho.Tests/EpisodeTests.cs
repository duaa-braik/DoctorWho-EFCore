using DoctorWho.Db.DataModels;

namespace DoctorWho.Tests
{
    ///Tests for Episodes are skipped to save time :)
    public class EpisodeTests : TestsBase
    {
        private readonly Episode EpisodeRpository;

        public EpisodeTests()
        {
            EpisodeRpository = new Episode(context);

            EpisodeRpository.Add(new Episode { });
        }
    }
}
