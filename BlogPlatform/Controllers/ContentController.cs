using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blog_template_practice.Models;
using blog_template_practice.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace blog_template_practice.Controllers
{
    public class ContentController : Controller
    {
        IRepository<Content> contentRepo;

        public ContentController(IRepository<Content> contentRepo)
        {
            this.contentRepo = contentRepo;
        }

        private void DropList()
        {
            var categories = contentRepo.PopulateCategoryList();
            ViewBag.category = new SelectList(categories, "Id", "Name");
        }

        public ViewResult Index()
        {
            var contentList = contentRepo.GetAll();
            return View(contentList);
        }

        public ViewResult Details(int id)
        {
            var content = contentRepo.GetById(id);

            return View(content);
        }

        public ViewResult Create(int id)
        {
            DropList();
            return View(new Content() { CategoryId = id});
        }

        [HttpPost]
        public ActionResult Create(Content model)
        {
            DropList();
            model.PublishDate = DateTime.Now;
            contentRepo.Create(model);
            ViewBag.Result = "You have created a post.";
            return View(model);
        }

        public ViewResult CreateByCategoryId(int categoryid)
        {
            DropList();

            return View(new Content() { CategoryId = categoryid });
        }

        public ViewResult Update(int id)
        {
            DropList();

            var content = contentRepo.GetById(id);

            return View(content);
        }
        [HttpPost]
        public ActionResult Update(Content model)
        {
            DropList();

            model.PublishDate = DateTime.Now;

            contentRepo.Update(model);

            ViewBag.Result = "You have updated your post";

            return View(model);
        }

        public ViewResult Delete(int id)
        {
            var content = contentRepo.GetById(id);

            contentRepo.Delete(content);

            return View(content);
        }
        [HttpPost]
        public ActionResult Delete(Content model)
        {
            contentRepo.Delete(model);
            return RedirectToAction("Index");
        }




    }
}
