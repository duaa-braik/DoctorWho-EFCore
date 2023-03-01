using DoctorWho.Db.DataModels;
using DoctorWho.Db.DBContext;

namespace DoctorWho.Db.Repositories
{
    public class DoctorRepository : IDoctorRepository
    {
        private readonly DoctorWhoCoreDbContext context;

        public DoctorRepository(DoctorWhoCoreDbContext context)
        {
            this.context = context ?? new DoctorWhoCoreDbContext();
        }
        public int Add(Doctor t)
        {
            throw new NotImplementedException();
        }

        public int Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public Doctor GetById(int id)
        {
            throw new NotImplementedException();
        }

        public int Update(Doctor t)
        {
            throw new NotImplementedException();
        }
    }
}
