using FileUpload.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace FileUpload.Controllers
{
    public class HomeController : Controller
    {
        DataContext db = new DataContext();
        IWebHostEnvironment _env;
        public HomeController(DataContext db, IWebHostEnvironment env)
        {
            this._env = env;

            this.db = db;

        }

        public IActionResult Index()
        {
            var list = db.Images.ToList();
            ViewBag.list = list;
            return View();
        }

        [HttpPost]
        public IActionResult Index(Image data)
        {
            if (data.ImagePath != null)
            {
                var extensions = Path.GetExtension(data.ImagePath.FileName);


                if (extensions == ".jpg" || extensions == ".png" || extensions == ".jpeg")
                {
                    var imagepath = Path.Combine(_env.WebRootPath, "img");
                    var fullpath = Path.Combine(imagepath, data.ImagePath.FileName);

                    var stream = new FileStream(fullpath, FileMode.Create);
                    data.ImagePath.CopyTo(stream);
                    data.ImageName = data.ImagePath.FileName;
                    db.Images.Add(data);
                    db.SaveChanges();
                    TempData["message"] = "Dosya Yükleme İşlemi Başarılı";
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["message"] = "Dosya Yükleme İşlemi Başarısız";
                }

            }


            return View();
        }

        public IActionResult Warning()
        {
            return View();
        }


          
        }
    
    }
    

