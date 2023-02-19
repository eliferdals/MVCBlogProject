using Microsoft.AspNetCore.Mvc;
using MVCBlogProject.Areas.Identity.Data;
using MVCBlogProject.Models;
using MVCBlogProject.Repositories.Abstract;
using System.Security.Claims;

namespace MVCBlogProject.Controllers
{
    //public class WritersController : Controller
    //{
    //    private readonly IWriterRepository writerRepository;
    //    private readonly IArticleCreateRepository articleRepository;
    //    public WritersController (IWriterRepository writerRepository, IArticleCreateRepository articleRepository)
    //    {
    //        this.writerRepository = writerRepository;
    //        this.articleRepository = articleRepository;
    //    }
    //    public IActionResult Index()
    //    {
    //        //var id = User.FindFirstValue(ClaimTypes.NameIdentifier); //profil yapmak için kullanıcı idsi veriyor
    //        //var writers = writerRepository.GetAll();
    //        //WritersIndexVM writersIndexVM = new WritersIndexVM();
    //        //writersIndexVM.ApplicationUsers = writers;
    //        //return View(writersIndexVM);

    //        //var id = User.FindFirstValue(ClaimTypes.NameIdentifier);
    //        //var user = writerRepository.GetByIdIncludeArticle(id);
    //        //WritersIndexVM writersIndexVM = new WritersIndexVM();
    //        //writersIndexVM.FirstName = user.FirstName;
    //        //writersIndexVM.LastName = user.LastName;
    //        //writersIndexVM.Id = user.Id;
    //        //writersIndexVM.Articles = user.Articles;
    //        //if (user.ImagePath != null)
    //        //{ writersIndexVM.ImagePath = user.ImagePath; }
    //        //return View(writersIndexVM);

    //        var articles = articleRepository.GetAllIncludeUsers(); 
    //        ArticlesCreateIndexVM articlesIndexVM = new ArticlesCreateIndexVM(); 
    //        articlesIndexVM.Articles = articles; 
    //        return View(articlesIndexVM);
    //    }


        //public IActionResult GetWritersListPartial()
        //{
        //    var id = User.FindFirstValue(ClaimTypes.NameIdentifier); //profil yapmak için kullanıcı idsi veriyor
        //    var writers = writerRepository.GetAll();
        //    WritersIndexVM writersIndexVM = new WritersIndexVM();
        //    writersIndexVM.ApplicationUsers = writers;
        //    return PartialView("_WriterListPartial", writersIndexVM);
        //}

        //public IActionResult GetUpdateWritersPartial(int id)
        //{
        //    var writer = writerRepository.GetById(id);
        //    WritersUpdateVM writersUpdateVM = new WritersUpdateVM();
        //    writersUpdateVM.Id = writer.Id;
        //    writersUpdateVM.Name = writer.FirstName;
        //    writersUpdateVM.Image = writer.ImagePath;
        //    return PartialView("_UpdateSchoolPartial", writersUpdateVM);
        //}

        //public IActionResult UpdateWriter(WritersUpdateVM writersUpdateVM)
        //{
        //    ApplicationUser writer = writerRepository.ApplicationUserGetById(writersUpdateVM.Id);


        //    writer.FirstName = writersUpdateVM.Name;
        //    writer.Id = writersUpdateVM.Id;

        //    var formFile = writersUpdateVM.UpdateImage;

        //    if (formFile != null)
        //    {
        //        var guideFileName = Guid.NewGuid() + Path.GetExtension(formFile.FileName);
        //        // proje içindeki image klasörüne kaydetme yolu
        //        var filePath = Path.Combine("wwwroot/image", guideFileName);

        //        // database e kaydetme yolu, localhost direkt wwwroot altında aradığı için başına wwwroot yazılmamalı
        //        var savedFile = Path.Combine("image", guideFileName);

        //        using (var stream = System.IO.File.Create(filePath))
        //        {
        //            formFile.CopyTo(stream);
        //        }

        //        writer.ImagePath = savedFile;
        //    }



        //    bool check = writerRepository.Update(writer);
        //    if (!check) return Json("fail");
        //    return Json("ok");
        //}
    }

