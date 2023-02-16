using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkTrackingProject.Controllers
{
    public class UserController : Controller
    {
        UserManager userManager = new UserManager(new EfUserDal());
        Context _context = new Context();
        public IActionResult Index()
        {
            List<SelectListItem> dropdownlist1 = (from x in _context.MDY_UserTypes.ToList()
                                                  select new SelectListItem
                                                  {
                                                      Text = x.TypeName,
                                                      Value = x.UserTypeId.ToString()
                                                  }).ToList();
            ViewBag.list = dropdownlist1;
            var value = userManager.GetUserWithUserType();
            return View(value);
        }
        [HttpPost]
        public IActionResult Create(User user)
        {
            userManager.TAdd(user);
            return RedirectToAction("Index");
        }
        //[HttpGet]
        //public IActionResult Edit(int id)
        //{
        //    var value = userManager.TGetById(id);
        //    return View(value);
        //}
        [HttpPost]
        public IActionResult Edit(User user)
        {
            userManager.TUpdate(user);
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            var getId = userManager.TGetById(id);
            userManager.TDelete(getId);
            return RedirectToAction("Index");
        }
    }
}
