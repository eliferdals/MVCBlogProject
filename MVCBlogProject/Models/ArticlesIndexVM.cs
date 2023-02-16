using MVCBlogProject.Entities.Concrete;

namespace MVCBlogProject.Models
{
    public class ArticlesIndexVM
    {
        public IEnumerable<Article> Articles { get; set; }
    }
}
