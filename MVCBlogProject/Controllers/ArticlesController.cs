using Microsoft.AspNetCore.Mvc;
using MVCBlogProject.Models;
using MVCBlogProject.Repositories.Abstract;

namespace MVCBlogProject.Controllers
{
    public class ArticlesController : Controller
    {
        private readonly IArticleRepository articleRepository;

        public ArticlesController(IArticleRepository articleRepository) 
        {
            this.articleRepository = articleRepository;
        }

        //GET:Article

        public IActionResult Index() 
        {
            var articles = articleRepository.GetAllIncludeChoosenTopic();
            ArticlesIndexVM articlesIndexVM= new ArticlesIndexVM();
            articlesIndexVM.Articles = articles;
            return View(articlesIndexVM);
        }
        //[HttpPost]
        //public IActionResult Create(Article article) 
        //{
        //    articleRepository.Add(article);
        //    return RedirectToAction(nameof(Index));
        //}

        //public IActionResult Update(int id) 
        //{
        //    var article = articleRepository.GetById(id);

        //    ArticleUpdateVM articleUpdateVM = new ArticleUpdateVM();
        //}
    }
}
