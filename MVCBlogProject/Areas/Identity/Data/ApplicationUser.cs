using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using MVCBlogProject.Entities.Concrete;

namespace MVCBlogProject.Areas.Identity.Data;

// Add profile data for application users by adding properties to the ApplicationUser class
public class ApplicationUser : IdentityUser
{
    public ApplicationUser()
    {
        Articles= new HashSet<Article>();
        ChoosenTopics= new HashSet<ChoosenTopic>();
    }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    [DisplayName("Upload File")]
    public string? ImagePath { get; set; }
    public string? Description { get; set; }
    public DateTime CreationDate { get; set; }

    public ICollection<ChoosenTopic>? ChoosenTopics { get; set; }

    public ICollection<Article>? Articles { get; set; }
}

