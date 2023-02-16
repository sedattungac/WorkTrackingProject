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
    public class UserTypeManager : IUserTypeService
    {
        IUserTypeDal _userTypeDal;

        public UserTypeManager(IUserTypeDal userTypeDal)
        {
            _userTypeDal = userTypeDal;
        }

        public void TAdd(UserType t)
        {
            _userTypeDal.Insert(t);
        }

        public void TDelete(UserType t)
        {
            _userTypeDal.Delete(t);
        }

        public UserType TGetById(int id)
        {
            return _userTypeDal.GetById(id);
        }

        public List<UserType> TGetList()
        {
            return _userTypeDal.GetList();
        }

        public void TUpdate(UserType t)
        {
            _userTypeDal.Update(t);
        }
    }
}
