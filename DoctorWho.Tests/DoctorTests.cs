using DoctorWho.Db.DataModels;

namespace DoctorWho.Tests
{
    public class DoctorTests : TestsBase
    {
        private readonly Doctor DoctorRepository;

        public DoctorTests()
        {
            DoctorRepository = new Doctor(context);

            DoctorRepository.Add(
                new Doctor
                {
                    DoctorName = "a",
                    DoctorNumber = 1,
                    FirstEpisodeDate = new DateTime(2000, 1, 1),
                    LastEpisodeDate = new DateTime(2005, 1, 1),
                    BirthDate = new DateTime(1990, 1, 1),
                });
        }

        [Fact]
        public void ShouldAddDoctorToDb()
        {
            AffectedRows = DoctorRepository.Add(
                new Doctor
                {
                    DoctorName = "a",
                    DoctorNumber = 1,
                    FirstEpisodeDate = new DateTime(2000, 1, 1),
                    LastEpisodeDate = new DateTime(2005, 1, 1),
                    BirthDate = new DateTime(1990, 1, 1),
                });
            Assert.Equal(1, AffectedRows);
        }

        [Theory]
        [InlineData(1, 1)]
        [InlineData(10, 0)]
        public void DeleteingADoctor(int Id, int Expected)
        {
            AffectedRows = DoctorRepository.Delete(Id);

            Assert.Equal(Expected, AffectedRows);
        }
    }
}
