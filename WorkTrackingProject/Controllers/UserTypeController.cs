using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkTrackingProject.Models;

namespace WorkTrackingProject.Controllers
{
    public class UserTypeController : Controller
    {
        UserTypeManager userTypeManager = new UserTypeManager(new EfUserTypeDal());
        Context context = new Context();
        public IActionResult Index()
        {
            //var value = userTypeManager.TGetList();
            //return View(value);
            UserTypeViewModel userTypeViewModel = new UserTypeViewModel();
            userTypeViewModel.UserTypeList = context.MDY_UserTypes.ToList();
            return View(userTypeViewModel);
        }
        [HttpPost]
        public IActionResult Create(UserType userType)
        {
            userTypeManager.TAdd(userType);
            return RedirectToAction("Index");
        }
        public IActionResult EditPartialView(int id)
        {
            var value = userTypeManager.TGetById(id);
            return View("EditPartialView", value);
        }
        [HttpPost]
        public IActionResult Edit(int id, string userTypeName)
        {

            var userValue = context.MDY_UserTypes.Find(id);
            userValue.TypeName = userTypeName;
            context.MDY_UserTypes.Update(userValue);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            var getId = userTypeManager.TGetById(id);
            userTypeManager.TDelete(getId);
            return RedirectToAction("Index");
        }
    }
}
