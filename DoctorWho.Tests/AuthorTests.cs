using DoctorWho.Db.DataModels;

namespace DoctorWho.Tests
{
    public class AuthorTests : TestsBase
    {
        private readonly Author AuthorRepository;

        public AuthorTests()
        {
            AuthorRepository = new Author(context);

            AuthorRepository.Add("a");
            AuthorRepository.Add("b");
            AuthorRepository.Add("c");
            AuthorRepository.Add("d");

        }

        [Fact]
        public void ShouldAddAnAuthor()
        {
            AffectedRows = AuthorRepository.Add("a");

            Assert.Equal(1, AffectedRows);
        }

        [Theory]
        [InlineData(1, 1)]
        [InlineData(100, 0)]
        public void ShouldDeleteAnExistingAuthor(int Id, int Expected)
        {
            AffectedRows = AuthorRepository.Delete(Id);

            Assert.Equal(Expected, AffectedRows);
        }
    }
}
