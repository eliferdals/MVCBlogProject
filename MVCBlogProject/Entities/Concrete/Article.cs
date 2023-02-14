using MVCBlogProject.Areas.Identity.Data;

namespace MVCBlogProject.Entities.Concrete
{
    public class Article
    {
        public Article()
        {
            ChoosenTopics = new HashSet<ChoosenTopic>();
        }
        public string Id { get; set; }
        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public string TitleName { get; set; }
        public decimal ReadTime { get; set; }
        public string Description { get; set; }
        public int ReadCount { get; set; }

        public ICollection<ChoosenTopic> ChoosenTopics { get; set; }
    }
}
