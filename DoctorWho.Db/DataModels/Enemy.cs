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
        private Enemy enemy;
        private DoctorWhoCoreDbContext context;

        public Enemy() { }
        public Enemy(DoctorWhoCoreDbContext Context)
        {
            Episodes = new List<Episode>();
            if(Context != null)
            {
                context = Context;
            } 
            else
            {
                context = new DoctorWhoCoreDbContext();
            }
            
        }

        public int EnemyId { get; set; }
        public string EnemyName { get; set; }
        public string? Description { get; set; }

        public List<Episode> Episodes { get; set; }

        public void CreateEnemy(string EnemyName)
        {
            enemy = new Enemy()
            {
                EnemyName = EnemyName
            };
            context.Add(enemy);
            context.SaveChanges();
        }

        public void UpdateEnemy(int EnemyId, string EnemyName, [Optional] string Description)
        {
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
