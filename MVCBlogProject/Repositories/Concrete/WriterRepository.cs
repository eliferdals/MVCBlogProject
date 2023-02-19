using Microsoft.EntityFrameworkCore;
using MVCBlogProject.Areas.Identity.Data;
using MVCBlogProject.Entities.Concrete;
using MVCBlogProject.Repositories.Abstract;

namespace MVCBlogProject.Repositories.Concrete
{
    public class WriterRepository : GenericRepository<ApplicationUser> , IWriterRepository
    {
        private readonly ApplicationDbContext db;
        public WriterRepository(ApplicationDbContext db) : base(db)
        {
            this.db = db;
        }


        public ApplicationUser ApplicationUserGetById(string Id)
        {
            return db.Set<ApplicationUser>().FirstOrDefault(a => a.Id == Id);
        }

        public ApplicationUser GetByIdIncludeArticle(string id)
        {
            throw new NotImplementedException();
        }

        //public ApplicationUser GetByIdIncludeArticle(string id)
        //{
        //   //return db.ApplicationUsers.Include( s => s.Article).FirstOrDefault(a => a.Id == id);
        //}
    }
}
