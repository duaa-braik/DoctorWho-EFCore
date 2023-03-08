using DoctorWho.Db.DBContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db.DataModels
{
    public class Enemy
    {
        public Enemy()
        {
            Episodes = new List<Episode>();
        }

        public int EnemyId { get; set; }
        public string EnemyName { get; set; }
        public string? Description { get; set; }

        public List<Episode> Episodes { get; set; }
    }
}
