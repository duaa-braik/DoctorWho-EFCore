using DoctorWho.Db.DataModels;

namespace DoctorWho.Tests
{
    public class CompanionTests : TestsBase
    {
        private Companion CompanionRepository;

        public CompanionTests()
        {
            CompanionRepository = new Companion(context);

            CompanionRepository.Add("a", "");
            CompanionRepository.Add("b", "");
            CompanionRepository.Add("c", "");

        }

        [Fact]
        public void ShouldAddACompanionToDb()
        {
            AffectedRows = CompanionRepository.Add("duaa", "a");

            Assert.Equal(1, AffectedRows);
        }

        [Fact]
        public void ShouldDeleteACompanion()
        {
            AffectedRows = CompanionRepository.Delete(1);

            Assert.Equal(1, AffectedRows);
        }

        [Fact]
        public void ShouldReturnZeroOnDeletingANonExistantCompanion()
        {
            AffectedRows = CompanionRepository.Delete(100);

            Assert.Equal(0, AffectedRows);
        }

    }
}
