using Microsoft.EntityFrameworkCore;
using MVCBlogProject.Areas.Identity.Data;
using MVCBlogProject.Entities.Concrete;
using MVCBlogProject.Repositories.Abstract;

namespace MVCBlogProject.Repositories.Concrete
{
    public class ArticleRepository : GenericRepository<Article>, IArticleRepository
    {
        private readonly ApplicationDbContext db;

        public ArticleRepository(ApplicationDbContext db) : base(db)
        {
            this.db = db;
        }

        public Article ArticleGetById(int id)
        {
            return db.ApplicationUsers.FirstOrDefault(b => b.Id == id);
        }

        public IEnumerable<Article> GetAllIncludeChoosenTopic()
        {
            return db.ApplicationUsers.Include(a => a.ChoosenTopics);
        }

        public IEnumerable<Article> MostRead()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Article> GetAllIncludeUsers()
        { 
            return db.Set<Article>().Include(s => s.ApplicationUser).OrderByDescending(a => a.ReadTime); 
        }
    }

}
