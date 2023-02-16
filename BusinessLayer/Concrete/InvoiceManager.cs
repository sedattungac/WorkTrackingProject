using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class InvoiceManager : IInvoiceService
    {
        IInvoiceDal _invoiceDal;

        public InvoiceManager(IInvoiceDal invoiceDal)
        {
            _invoiceDal = invoiceDal;
        }

        public void TAdd(Invoice t)
        {
            _invoiceDal.Insert(t);
        }

        public void TDelete(Invoice t)
        {
            _invoiceDal.Delete(t);
        }

        public Invoice TGetById(int id)
        {
            return _invoiceDal.GetById(id);
        }

        public List<Invoice> TGetList()
        {
            return _invoiceDal.GetList();
        }

        public void TUpdate(Invoice t)
        {
            _invoiceDal.Update(t);
        }
    }
}
