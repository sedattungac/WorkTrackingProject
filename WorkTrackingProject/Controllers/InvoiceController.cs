using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkTrackingProject.Controllers
{
    public class InvoiceController : Controller
    {
        InvoiceManager invoiceManager = new InvoiceManager(new EfInvoiceDal());
        Context _context = new Context();
        public IActionResult Index()
        {
            var value = invoiceManager.TGetList();
            return View(value);
        }
        [HttpPost]
        public IActionResult Create(Invoice invoice)
        {
            invoiceManager.TAdd(invoice);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult Edit(Invoice invoice)
        {
            invoiceManager.TUpdate(invoice);
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            var getId = invoiceManager.TGetById(id);
            invoiceManager.TDelete(getId);
            return RedirectToAction("Index");
        }
    }
}
