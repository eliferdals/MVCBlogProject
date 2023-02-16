using MVCBlogProject.Areas.Identity.Data;

namespace MVCBlogProject.Entities.Concrete
{
    public class ChoosenTopic
    {
        public ChoosenTopic()
        {
            Articles = new HashSet<Article>();
            ApplicationUsers = new HashSet<ApplicationUser>();
        }
        public int Id { get; set; }
        public string TopicName { get; set; } 

        public ICollection<Article> Articles { get; set; }

        public ICollection<ApplicationUser> ApplicationUsers { get; set; }
    }
}
