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
            return db.Articles.FirstOrDefault(b => b.Id == id);
        }

        public IEnumerable<Article> GetAllIncludeChoosenTopic()
        {
            return db.Articles.Include(a => a.ChoosenTopics);
        }

        public IEnumerable<Article> MostRead()
        {
            throw new NotImplementedException();
        }
    }
}
