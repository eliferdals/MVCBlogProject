namespace MVCBlogProject.Models
{
    public class WritersUpdateVM
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public string Image { get; set; }
        public IFormFile UpdateImage { get; set; }
    }
}
