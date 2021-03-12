﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blog_template_practice.Models;
using blog_template_practice.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace blog_template_practice.Controllers
{
    public class ContentController : Controller
    {
        IRepository<Content> contentRepo;

        public ContentController(IRepository<Content> contentRepo)
        {
            this.contentRepo = contentRepo;
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

        public ViewResult Create()
        {
            return View(new Content());
        }

        [HttpPost]
        public ViewResult Create(Content model)
        {

            contentRepo.Create(model);
            ViewBag.Result = "You have created a post.";
            return View(model);
        }

        
        

        

    }
}
