using DoctorWho.Db.DataModels;
using DoctorWho.Db.DBContext;

namespace DoctorWho
{
    public class Views
    {
        public List<ViewEpisodes> ViewEpisodes()
        {
            using var context = new DoctorWhoCoreDbContext();

            var Episodes = context.ViewEpisodes.ToList();

            return Episodes;
        }
    }
}
