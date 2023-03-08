﻿using DoctorWho.Db.DBContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db.DataModels
{
    public class Companion
    {
        public Companion()
        {
            Episodes = new List<Episode>();
        }

        public int CompanionId { get; set; }
        public string CompanionName { get; set; }
        public string? WhoPlayed { get; set; }

        public List<Episode> Episodes { get; set; }
    }
}
