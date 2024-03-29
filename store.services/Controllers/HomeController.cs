﻿using store.services.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace store.services.Controllers
{
    public class HomeController : Controller
    {
        private readonly storeDbcontext _context;

        public HomeController()
        {
            _context = new storeDbcontext();
        }
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        [HttpGet]
        public JsonResult GetAllProducts()
        {
            var temp = _context.Product.ToList();
            return Json(temp, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetProductById(int Id)
        {
            var temp = _context.Product.Find(Id);
            return Json(temp, JsonRequestBehavior.AllowGet);
        }

        public JsonResult RegisterNewProduct(int CategoryId, int BrandId, string ModelName, string Description)
        {
            _context.Product.Add(new Areas.HelpPage.Models.product()
            {
                BrandId = BrandId,
                CategoryId = CategoryId,
                Description = Description,
                ModelName = ModelName
            });
            _context.SaveChanges();
            return Json("succesfully", JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetAllCountry()
        {
            var temp = _context.Country.ToList();
            return Json(temp, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetAllCategory()
        {
            var temp = _context.Category.ToList();
            return Json(temp, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetAllCompany()
        {
            var temp = _context.Company.ToList();
            return Json(temp, JsonRequestBehavior.AllowGet);
        }

    }
}
