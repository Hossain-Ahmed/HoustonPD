using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HoustonPD.Models;
using HoustonPD.ViewModels;
using HoustonPD.Repositories;
using System.Data.Entity.Validation;

namespace HoustonPD.Controllers
{
    public class UserController : Controller
    {
        private readonly UserRepository _userRepository;

        private ProjectDbContext _db = new ProjectDbContext();
        // GET: User
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {

            return View();
        }

        public ActionResult Register()
        {
            return View();
        }

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Register([Bind(Include = "Id,Name,Email,Password,RepeatPassword")] User user)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Users.Add(user);
        //        db.SaveChanges();
        //        return RedirectToAction("Login");
        //    }

        //    return View(User);

        //}

        [HttpPost]
        // [ValidateAntiForgeryToken]
        public ActionResult Register(UserViewModel userViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(userViewModel);
            }

            var user = new User();

            if (!string.IsNullOrEmpty(userViewModel.Name))
            {
                {

                    user.Name = userViewModel.Name;
                    user.UserName = userViewModel.UserName;
                    user.Email = userViewModel.Email;
                   
                   if(userViewModel.Password == userViewModel.RepeatPassword)
                    {
                      user.Password = userViewModel.Password;
                    }
                    else
                    {
                        return View(user);
                    }
                }
            }

            _db.Users.Add(user);
            _db.SaveChanges();

            return RedirectToAction("Login", "User");
        }
        [HttpGet]
        public ActionResult Login(UserViewModel userViewModel)
        {
            var user = new User
            {
                UserName = userViewModel.UserName,
                Email = userViewModel.UserName,
                Password = userViewModel.Password
            };
            var isExist = _db.Users.Any(x =>( x.UserName.Equals(user.UserName) || x.Email.Equals(user.Email))
            && x.Password.Equals(user.Password));
            //var isExist = _userRepository.IsUserValid(user);

            if (isExist)
            {
                return RedirectToAction("index", "User");
            }
            else
            {
                ViewBag.ValidationMessage = "Username or Password is not correct!";

                return View();
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _db.Dispose();
            }
            base.Dispose(disposing);
        }

    }
}