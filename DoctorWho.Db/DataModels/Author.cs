using DoctorWho.Db.DBContext;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db.DataModels
{
    public class Author
    {
        private DoctorWhoCoreDbContext context;

        public Author() { }
        public Author(DoctorWhoCoreDbContext Context)
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

        public int AuthorId { get; set; }
        public string AuthorName { get; set; }

        public List<Episode> Episodes { get; set; }

        private Author author;

        public Author GetById(int Id, DoctorWhoCoreDbContext context)
        {
            return context.Authors.Find(Id);
        }

        public void Add(string Name)
        {
            author = new Author()
            {
                AuthorName = Name
            };
            context.Authors.Add(author);
            context.SaveChanges();
        }

        public void Update(int Id, string Name)
        {
            author = GetById(Id, context);

            author.AuthorName = Name;
            context.SaveChanges();
        }

        public void Delete(int Id)
        {
            author = GetById(Id, context);

            context.Authors.Remove(author);
            context.SaveChanges();
        }
    }
}
