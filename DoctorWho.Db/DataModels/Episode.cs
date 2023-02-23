using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db.DataModels
{
    public class Episode
    {
        public int EpisodeId { get; set; }
        public int SeriesNumber { get; set; }
        public int EpisodeNumber { get; set; }
        public EpisodeType EpisodeType { get; set; }
        public string Title { get; set; }
        public DateTime EpisodeDate { get; set; }
        public string? Notes { get; set; }

        public int AuthorId { get; set; }
        public Author Author { get; set; }

        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; }

        public List<Companion> Companions { get; set; }
        public List<Enemy> Enemies { get; set; }

    }
}
