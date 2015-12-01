using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RepoBlog.Factories;

namespace MVC_Blog.Controllers
{
    public class BlogController : Controller
    {
        PostFac pf = new PostFac();

        // GET: Blog
        public ActionResult Index()
        {
            return View(pf.GetIndexData());
        }
    }
}