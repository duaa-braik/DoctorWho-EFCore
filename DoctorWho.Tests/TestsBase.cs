using DoctorWho.Db.DBContext;
using Microsoft.EntityFrameworkCore;

namespace DoctorWho.Tests
{
    public class TestsBase
    {
        protected DbContextOptions<DoctorWhoCoreDbContext> DbContextOptions;
        protected DoctorWhoCoreDbContext context;
        protected int AffectedRows;

        public TestsBase()
        {
            var DbName = $"Tests_{DateTime.Now}";
            DbContextOptions = new DbContextOptionsBuilder<DoctorWhoCoreDbContext>()
                .UseInMemoryDatabase(DbName)
                .Options;

            context = new DoctorWhoCoreDbContext(DbContextOptions);
        }
    }
}
