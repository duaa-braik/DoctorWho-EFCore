using DoctorWho.Db.DataModels;

namespace DoctorWho.Tests
{
    public class EnemyTests : TestsBase
    {
        private readonly Enemy EnemyRepository;

        public EnemyTests()
        {
            EnemyRepository = new Enemy(context);

            EnemyRepository.CreateEnemy("a");
            EnemyRepository.CreateEnemy("b");
            EnemyRepository.CreateEnemy("c");
        }

        [Fact]
        public void ShouldAddAnEnemyToDB()
        {
            AffectedRows = EnemyRepository.CreateEnemy("duaa");

            Assert.Equal(1, AffectedRows);
        }

        [Fact]
        public void ShouldDeleteAnEnemy()
        {
            AffectedRows = EnemyRepository.DeleteEnemy(1);

            Assert.Equal(1, AffectedRows);
        }

        [Fact]
        public void ShouldReturnZero()
        {
            AffectedRows = EnemyRepository.DeleteEnemy(100);

            Assert.Equal(0, AffectedRows);
        }
    }
}