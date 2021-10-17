using E_Commerce_Extended.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace E_Commerce_Extended.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(User s)
        {
            var db = new E_CommerceEntities();
            db.Users.Add(s);
            db.SaveChanges();
            return RedirectToAction("");

        }
        public ActionResult Login()
        {
            return View();
        }
    }
}