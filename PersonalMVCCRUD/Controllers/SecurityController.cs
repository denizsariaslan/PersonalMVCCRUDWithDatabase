using PersonalMVCCRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace PersonalMVCCRUD.Controllers
{
    public class SecurityController : Controller
    {
        PersonalDBEntities1 db = new PersonalDBEntities1(); 
        // GET: Security
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(User user)
        {
            var userInDb = db.User.FirstOrDefault(x => x.Name == user.Name && x.Password == user.Password);
            if(userInDb != null)
            {
                FormsAuthentication.SetAuthCookie(userInDb.Name, false);
                return RedirectToAction("index","Departments");
            }
            else
            {
                ViewBag.Message = "Invalid Name or Password";
                return View();
            }
            
        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }
    }
}