using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Invoice
    {
        [Key]
        public int InvoiceId { get; set; }
        public int ServiceId { get; set; }
        public virtual Service Service { get; set; }
        public int FicheNo { get; set; }
        public DateTime Date { get; set; }
        public string Amount { get; set; }
        public decimal Price { get; set; }
        public decimal Total { get; set; }
        public int Vatrate { get; set; }
        public decimal VatAmount { get; set; }
        public decimal GeneralTotal { get; set; }
        public int UserId { get; set; }
        public int Status { get; set; }
        public int DocNumber { get; set; }
        public decimal AdminTotal { get; set; }
        public decimal AccTotal { get; set; }
    }
}
