using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MVCBlogProject.Models;
using MVCBlogProject.Repositories.Abstract;
using MVCBlogProject.Repositories.Concrete;
using System.Diagnostics;
using System.Security.Claims;

namespace MVCBlogProject.Controllers
{
    public class HomeController : Controller
    {
        
        private readonly ILogger<HomeController> _logger;
        //private readonly IArticleRepository articleRepository;

        public HomeController(ILogger<HomeController> logger, IArticleCreateRepository articleRepository)
        {
            _logger = logger;
            //this.articleRepository = articleRepository;
        }

        public IActionResult Index()
        {
            //ArticlesIndexVM articleIndexVM = new ArticlesIndexVM();
            //var articles = articleRepository.GetAll();
            //articleIndexVM.Articles = articles;

            //return View(articleIndexVM);
            return View();
        }
        [Authorize(Policy = "IsWriter")] //Claim based authorization
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


    }
}