using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using E_Commerce.Data;
using E_Commerce.Models;
using E_Commerce.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace E_Commerce.Controllers
{
    [Authorize(Roles = WebConstant.AdminRole)]
    public class ProductController : Controller
    {

        private readonly ApplicationDbContext _db;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public ProductController(ApplicationDbContext db, IWebHostEnvironment webHostEnvironment)
        {
            _db = db;
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index()
        {
            IEnumerable<Product> objList = _db.Product.Include(u => u.Category).Include(u => u.ApplicationType);
            //foreach (var obj in objList)
            //{
            //    obj.Category = _db.Category.FirstOrDefault(x => x.Id == obj.CategoryId);
            //    obj.ApplicationType = _db.ApplicationType.FirstOrDefault(x => x.Id == obj.ApplicationTypeId);
            //};
            
            return View(objList);
        }

        //GET - UpSert
        public IActionResult UpSert(int? id)
        {

            //IEnumerable<SelectListItem> CategoryDropDown = _db.Category.Select(i => new SelectListItem
            //{
            //    Text = i.Name,
            //    Value = i.Id.ToString()
            //});

            ////ViewBag.CategoryDropDown = CategoryDropDown;
            //ViewData["CategoryDropDown"] = CategoryDropDown;

           // Product product = new Product();

           ProductVM productVm = new ProductVM()
           {
               Product = new Product(),
               CategorySelectList = _db.Category.Select(i => new SelectListItem
               {
                   Text = i.Name,
                   Value = i.Id.ToString()
               }),
               ApplicationTypeSelectList = _db.ApplicationType.Select(i => new SelectListItem
               {
                   Text = i.Name,
                   Value = i.Id.ToString()
               })
           };
            if (id == null)
            {
                return View(productVm);
            }
            else
            {
                productVm.Product = _db.Product.Find(id);
                if (productVm.Product == null)
                {
                    return NotFound();
                }

                return View(productVm);
            }
           
        }


        ////POST - UpSert
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UpSert(ProductVM productVm)
        {
            if (ModelState.IsValid)
            {

                var files = HttpContext.Request.Form.Files;
                string webRootPath = _webHostEnvironment.WebRootPath;

                if (productVm.Product.Id == 0)
                {
                    string upload = webRootPath + WebConstant.ImagePath;
                    string fileName = Guid.NewGuid().ToString();
                    string extension = Path.GetExtension(files[0].FileName);

                    using (var fileStream = new FileStream(Path.Combine(upload, fileName + extension), FileMode.Create))
                    {
                        files[0].CopyTo(fileStream);
                    }

                    productVm.Product.Image = fileName + extension;
                    _db.Product.Add(productVm.Product);

                }
                else
                {
                    var objFromDb = _db.Product.AsNoTracking().FirstOrDefault(u => u.Id == productVm.Product.Id);
                    if (files.Count > 0)
                    {
                        string upload = webRootPath + WebConstant.ImagePath;
                        string fileName = Guid.NewGuid().ToString();
                        string extension = Path.GetExtension(files[0].FileName);

                        var oldFile = Path.Combine(upload, objFromDb.Image);

                        if (System.IO.File.Exists(oldFile))
                        {
                            System.IO.File.Delete(oldFile);
                        }

                        using (var fileStream = new FileStream(Path.Combine(upload, fileName + extension), FileMode.Create))
                        {
                            files[0].CopyTo(fileStream);
                        }

                        productVm.Product.Image = fileName + extension;
                    }

                    else
                    {
                        productVm.Product.Image = objFromDb.Image;
                    }

                    _db.Product.Update(productVm.Product);
                }

                _db.SaveChanges();

                return RedirectToAction("Index");
            }

            productVm.CategorySelectList = _db.Category.Select(i => new SelectListItem
            {
                Text = i.Name,
                Value = i.Id.ToString()
            });
            productVm.ApplicationTypeSelectList = _db.ApplicationType.Select(i => new SelectListItem
            {
                Text = i.Name,
                Value = i.Id.ToString()
            });

            return View(productVm);



        }





        //GET - DELETE
        public IActionResult Delete(int? id)
        {

            if (id == null || id == 0)
            {
                return NotFound();
            }

            Product product = _db.Product.Include(u => u.Category).Include(u => u.ApplicationType).FirstOrDefault(u => u.Id ==id);
            //product.Category = _db.Category.Find(product.CategoryId);

            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }


       // POST - DELETE
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int? id)
        {
            var obj = _db.Product.Find(id);
            if (obj == null)
            {
                return NotFound();
            }


            string upload = _webHostEnvironment.WebRootPath + WebConstant.ImagePath;
           

            var oldFile = Path.Combine(upload, obj.Image);

            if (System.IO.File.Exists(oldFile))
            {
                System.IO.File.Delete(oldFile);
            }

            _db.Product.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");



        }


    }

}
