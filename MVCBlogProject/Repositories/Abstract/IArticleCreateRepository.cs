using MVCBlogProject.Entities.Concrete;

namespace MVCBlogProject.Repositories.Abstract
{
    public interface IArticleCreateRepository : IRepository<Article>
    {
        IEnumerable<Article> GetAllIncludeChoosenTopic();
        public Article ArticleGetById(int id);

        IEnumerable<Article> GetAllIncludeUsers();
        IEnumerable<Article> MostRead();
    }
}
