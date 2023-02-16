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
    public class ServiceController : Controller
    {
        ServiceManager serviceManager = new ServiceManager(new EfServiceDal());
        Context _context = new Context();
        public IActionResult Index()
        {
            var value = serviceManager.TGetList();
            return View(value);
        }
        [HttpPost]
        public IActionResult Create(Service service)
        {
            serviceManager.TAdd(service);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult Edit(Service service)
        {
            serviceManager.TUpdate(service);
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            var getId = serviceManager.TGetById(id);
            serviceManager.TDelete(getId);
            return RedirectToAction("Index");
        }
    }
}
