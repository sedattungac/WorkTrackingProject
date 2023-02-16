using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkTrackingProject.Models
{
    public class UserTypeViewModel
    {
        public IEnumerable<UserType> UserTypeList  { get; set; }
    }
}
