using FileUpload.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FileUpload.Controllers
{
    public class CommentController : Controller
    {
        DataContext db = new DataContext();
        public CommentController(DataContext db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {
            var list = db.Comments.Where(x => x.Status == true).ToList();
            ViewBag.list = list;
            return View();
        }
        [HttpPost]
        public IActionResult Index(Comment data)
        {
            if (data.CommentText!=null && data.FullName!=null)
            {
               
                db.Comments.Add(data);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
        public IActionResult Detail(string id)
        {
            string guidOlustur = Guid.NewGuid().ToString();
           
            
            var detail = db.Comments.Find(id);
            guidOlustur = id;
            id = detail.CommentId.ToString();
            return View(detail);
        }

    }
}
