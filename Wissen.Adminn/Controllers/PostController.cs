using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Wissen.Model;
using Wissen.Service;

namespace Wissen.Adminn.Controllers
{
    public class PostController : Controller
    {
        private readonly IPostService postService;
        private readonly ICategoryService categoryService;
        public PostController(IPostService postService, ICategoryService categoryService)
        {
            this.categoryService = categoryService;
            this.postService = postService;
        }
        // GET: Post
        public ActionResult Index()
        {
            var post = postService.GetAll();
            return View(post);
        }
        public ActionResult Create()
        {
            var post = new Post();
            ViewBag.CategoryId = new SelectList(categoryService.GetAll(), "Id", "Name");
            return View(post);
        }
        [HttpPost]
        public ActionResult Create(Post post)
        {
            if (ModelState.IsValid)
            {
                postService.Insert(post);
                return RedirectToAction("index");
            }
            
            ViewBag.CategoryId = new SelectList(categoryService.GetAll(), "Id", "Name", post.CategoryId);
            return View(post);
        }
        public ActionResult Edit(int id)
        {
            var post = postService.Fİnd(id);
            if (post == null)
            {
                return HttpNotFound();

            }
            ViewBag.CategoryId = new SelectList(categoryService.GetAll(), "Id", "Name", post.CategoryId);
            return View(post);
        }[HttpPost]
        [ValidateInput(false)]
        public ActionResult Edit(Post post)
        {
            if (ModelState.IsValid)
            {
                var model = postService.Fİnd(post.Id);
                model.Title = post.Title;
                model.Description = post.Description;                           
                model.CategoryId = post.CategoryId;
                postService.Update(model);

                return RedirectToAction("index");

            }
            ViewBag.CategoryId = new SelectList(categoryService.GetAll(), "Id", "Name", post.CategoryId);
            return View(post);
        }
        public ActionResult Delete(int id)
        {
            postService.Delete(id);
            return RedirectToAction("index");
        }
        public ActionResult Get(int id)
        {
            var post = postService.Fİnd(id);
            return View(post);
        }
    }
}