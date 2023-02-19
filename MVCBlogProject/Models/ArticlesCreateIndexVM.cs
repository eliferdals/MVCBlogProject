using MVCBlogProject.Entities.Concrete;

namespace MVCBlogProject.Models
{
    public class ArticlesCreateIndexVM
    {
        public IEnumerable<Article> Articles { get; set; }

        public string? Name { get; set; }
        public string? Content { get; set; }
        public string Image { get; set; }
        public IFormFile UpdateImage { get; set; }
        public string UserId { get; set; }


    }
}
