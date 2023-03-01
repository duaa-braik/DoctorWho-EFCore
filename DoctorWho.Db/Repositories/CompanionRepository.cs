using DoctorWho.Db.DataModels;
using DoctorWho.Db.DBContext;

namespace DoctorWho.Db.Repositories
{
    public class CompanionRepository : ICompanionRepository
    {
        private readonly DoctorWhoCoreDbContext context;

        public CompanionRepository(DoctorWhoCoreDbContext context)
        {
            this.context = context ?? new DoctorWhoCoreDbContext();
        }
        public int Add(Companion t)
        {
            throw new NotImplementedException();
        }

        public int Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public Companion GetById(int id)
        {
            throw new NotImplementedException();
        }

        public int Update(Companion t)
        {
            throw new NotImplementedException();
        }
    }
}
