using DoctorWho.Db.DBContext;
using System;
using System.Collections.Generic;
using System.Linq;
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

        private Enemy enemy;

        public void CreateEnemy(string EnemyName)
        {
            using var context = new DoctorWhoCoreDbContext();

            enemy = new Enemy
            {
                EnemyName = EnemyName
            };
            context.Add(enemy);
            context.SaveChanges();
        }

        public void UpdateEnemy(int EnemyId, string EnemyName, [Optional] string Description)
        {
            using var context = new DoctorWhoCoreDbContext();
            enemy = GetEnemyById(EnemyId, context);

            if (enemy != null)
            {
                if (!string.IsNullOrEmpty(EnemyName))
                {
                    enemy.EnemyName = EnemyName;
                }
                if (!string.IsNullOrEmpty(Description))
                {
                    enemy.Description = Description;
                }
                context.SaveChanges();
            }

        }

        public void DeleteEnemy(int EnemyId)
        {
            using var context = new DoctorWhoCoreDbContext();

            enemy = GetEnemyById(EnemyId, context);

            if (enemy != null)
            {
                context.Enemies.Remove(enemy);
                context.SaveChanges();
            }
        }

        private Enemy GetEnemyById(int EnemyId, DoctorWhoCoreDbContext context)
        {
            return context.Enemies.Find(EnemyId);
        }
    }
}
