using MonaWebApp.Models.EntityFramework;
using System.Linq;
using System.Web.Mvc;

namespace MonaWebApp.Controllers
{
    public class AdminController : Controller
    {

        MonaEntities db = new MonaEntities();
        // GET: Admin

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult BlogCategory()
        {
            var category = db.BlogCategories.ToList();
            return View(category);
        }
        [HttpGet]
        public ActionResult CreateCategory()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateCategory(BlogCategory category)
        {
            db.BlogCategories.Add(category);
            db.SaveChanges();
            //return RedirectToAction("BlogCategory", "Admin");
            return RedirectToAction("BlogCategory");
        }
        public ActionResult Delete(int id)
        {
            BlogCategory cat = db.BlogCategories.Find(id);
            db.BlogCategories.Remove(cat);
            db.SaveChanges();
            return RedirectToAction("BlogCategory", "Admin");
        }

        //[HttpGet]
        //public ActionResult Update(int BlogCategoryId)
        //{
        //    var model = db.BlogCategories.Find(BlogCategoryId);
        //    if (model == null)
        //        return HttpNotFound();
        //    return View("DepartmentForm", model);
        //}
        //[HttpPost]
        //public ActionResult Update(BlogCategory cat)
        //{
        //    if (cat.BlogCategoryId == 0)
        //    {
        //        db.BlogCategories.Add(cat);
        //    }
        //    else
        //    {
        //        BlogCategory updateableCategory = db.BlogCategories.Find(cat.BlogCategoryId);
        //        if (updateableCategory == null)
        //        {
        //            return HttpNotFound();
        //        }
        //        updateableCategory.BlogCategoryName = cat.BlogCategoryName;

        //    }

        //    db.SaveChanges();


        //    return RedirectToAction("BlogCategory", "Admin");
        //}

        //[HttpPost]
        //public ActionResult Submit(BlogCategory category)
        //{
        //    if (category.BlogCategoryId == 0)
        //    {
        //        db.BlogCategories.Add(category);
        //    }
        //    else
        //    {
        //        var updateableCategory = db.BlogCategories.Find(category.BlogCategoryId);
        //        if (updateableCategory == null)
        //        {
        //            return HttpNotFound();
        //        }
        //        updateableCategory.BlogCategoryName = category.BlogCategoryName;

        //    }

        //    db.SaveChanges();


        //    return RedirectToAction("BlogCategory","Admin");
        //}

        public ActionResult Blog()
        {
            var blog = db.Blogs.ToList();
            return View(blog);
        }
        //Blog---------------------------------------------------------------/////////
        [HttpGet]
        public ActionResult CreateBlog()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateBlog(Blog blog)
        {
            db.Blogs.Add(blog);
            return RedirectToAction("Blogs");
        }

        [HttpGet]
        public ActionResult DeleteBlog()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DeleteBlog(int id)
        {
            Blog blog = new Blog();
            db.Blogs.Remove(blog);
            db.SaveChanges();
            return RedirectToAction("Blog");
        }







        public ActionResult Casting()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
        public ActionResult ModelsPage()
        {
            return View();
        }
        public ActionResult Projects()
        {
            return View();
        }
        public ActionResult SingleBlog()
        {
            return View();
        }
    }
}