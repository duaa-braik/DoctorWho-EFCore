﻿using DoctorWho.Db.DBContext;

namespace DoctorWho.Db.DataModels
{
    public class Episode
    {
        public Episode()
        {
            Companions = new List<Companion>();
            Enemies = new List<Enemy>();
        }

        public int EpisodeId { get; set; }
        public int SeriesNumber { get; set; }
        public int EpisodeNumber { get; set; }
        public EpisodeType EpisodeType { get; set; }
        public string Title { get; set; }
        public DateTime EpisodeDate { get; set; }
        public string? Notes { get; set; }

        public int AuthorId { get; set; }
        public Author Author { get; set; }

        public int? DoctorId { get; set; }
        public Doctor Doctor { get; set; }

        public List<Companion> Companions { get; set; }
        public List<Enemy> Enemies { get; set; }

        private Episode episode;
    }
}
