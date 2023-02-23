﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db.DataModels
{
    public class Author
    {
        public int AuthorId { get; set; }
        public string AuthorName { get; set; }

        public List<Episode> Episodes { get; set; }
    }
}
