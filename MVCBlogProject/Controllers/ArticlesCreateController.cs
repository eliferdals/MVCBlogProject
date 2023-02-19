using Microsoft.AspNetCore.Mvc;
using MVCBlogProject.Entities.Concrete;
using MVCBlogProject.Models;
using MVCBlogProject.Repositories.Abstract;

namespace MVCBlogProject.Controllers
{
    public class ArticlesCreateController : Controller
    {
        private readonly IArticleCreateRepository articleRepository;

        public ArticlesCreateController(IArticleCreateRepository articleRepository) 
        {
            this.articleRepository = articleRepository;
        }

        //GET:Article

        public IActionResult Index() 
        {
            var articles = articleRepository.GetAllIncludeChoosenTopic();
            ArticlesCreateIndexVM articlesIndexVM= new ArticlesCreateIndexVM();
            articlesIndexVM.Articles = articles;
          

            return View(articlesIndexVM);
        }
        [HttpPost]
        //public IActionResult Create(Article article)
        //{
        //    articleRepository.Add(article);
        //    return RedirectToAction(nameof(Index));
        //}

        public IActionResult AddArticle(string id, Article article)
        {
            ArticlesCreateIndexVM artilesIndexVM = new ArticlesCreateIndexVM();
            artilesIndexVM.UserId = id;
            return View(artilesIndexVM);
        }
        [HttpPost]
        public IActionResult AddArticle(ArticlesCreateIndexVM articlesIndexVM) 
        { Article article = new Article(); 
            article.Content = articlesIndexVM.Content;
            article.ApplicationUserId = articlesIndexVM.UserId; 
            article.TitleName = articlesIndexVM.Name;
            //articlesIndexVM.ChoosenTopic = article.ApplicationUserId;
            articleRepository.Add(article); 
            return RedirectToAction(nameof(Index)); 
        }


    }
}
