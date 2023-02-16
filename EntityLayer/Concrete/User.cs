using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string ErpCode { get; set; }
        public string Email { get; set; }
        public int UserTypeId { get; set; }
        public virtual UserType UserType { get; set; }
    }
}
