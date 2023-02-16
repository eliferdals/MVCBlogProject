using MVCBlogProject.Areas.Identity.Data;

namespace MVCBlogProject.Entities.Concrete
{
    public class Article
    {
        public Article()
        {
            ChoosenTopics = new HashSet<ChoosenTopic>();
        }
        public int Id { get; set; }
        public int ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public string TitleName { get; set; }
        public decimal ReadTime { get; set; }
        public int ReadCount { get; set; }

        public ICollection<ChoosenTopic> ChoosenTopics { get; set; }
    }
}
